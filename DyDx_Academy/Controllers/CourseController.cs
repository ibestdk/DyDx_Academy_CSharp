using DyDx_Academy.Data.Services;
using DyDx_Academy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _services;

        public CourseController(ICourseService services)
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var allCourse = await _services.GetAllAsync();

            return View(allCourse);
        }
        public IActionResult MyCourse()
        {
            return View("../Course/MyCourse/Index");
        }

        public async Task<IActionResult> Search(string searchString)
        {
            var allCourse = await _services.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allCourse.Where(n => n.Name.Contains(searchString) || n.Description.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }

                return View("Index", allCourse);
        }


        //Get: Courses/Details/@number_course
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var courseDetail = await _services.GetCoursesByIdAsync(id);
            return View(courseDetail);

        }

        //Get: Courses/Create
        public async Task<IActionResult> Create()
        {
            var courseDropdownData = await _services.GetNewCourseDropdownsValues();
            ViewBag.Instructor = new SelectList(courseDropdownData.Instructors, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewCoursesVM course)
        {
            if(!ModelState.IsValid)
            {
                var courseDropdownData = await _services.GetNewCourseDropdownsValues();

                ViewBag.Instructor = new SelectList(courseDropdownData.Instructors, "Id", "FullName");
                return View(course);
            }

            await _services.AddNewCourseAsync(course);

            return RedirectToAction(nameof(Index));
        }

        //Get: Courses/Edit/#number
        public async Task<IActionResult> Edit(int id)
        {
            var courseDetails = await _services.GetCoursesByIdAsync(id);
            if (courseDetails == null) return View("NotFound");

            var response = new NewCoursesVM()
            {
                Id = courseDetails.Id,
                Name = courseDetails.Name,
                Description = courseDetails.Description,
                Price = courseDetails.Price,
                ImageURL = courseDetails.ImageURL,
                CourseCategory = courseDetails.CourseCategory,
                InstructorIds = courseDetails.Instructor_Course.Select(n => n.InstructorId).ToList(),
            };

            var courseDropdownData = await _services.GetNewCourseDropdownsValues();
            ViewBag.Instructor = new SelectList(courseDropdownData.Instructors, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,NewCoursesVM course)
        {
            if (id != course.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var courseDropdownData = await _services.GetNewCourseDropdownsValues();

                ViewBag.Instructor = new SelectList(courseDropdownData.Instructors, "Id", "FullName");
                return View(course);
            }

            await _services.UpdateCourseAsync(course);
            return RedirectToAction(nameof(Index));
        }


    }
}
