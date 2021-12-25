using DyDx_Academy.Data.Base;
using DyDx_Academy.Models;
using DyDx_Academy.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Data.Services
{
    public class CourseService:EntityBaseRepository<Courses>, ICourseService
    {
        private readonly ApplicationDbContext _context;
        public CourseService(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public async Task AddNewCourseAsync(NewCoursesVM data)
        {
            var newCourse = new Courses()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                Create = DateTime.Now,
                CourseCategory = data.CourseCategory,

            };
            await _context.Courses.AddAsync(newCourse);
            await _context.SaveChangesAsync();

            //Add Course Instructor
            foreach(var instructorsId in data.InstructorIds)
            {
                var newInstructorCourse = new Instructor_Course()
                {
                    CourseId = newCourse.Id,
                    InstructorId = instructorsId
                };
                await _context.Instructor_Course.AddAsync(newInstructorCourse);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Courses> GetCoursesByIdAsync(int id)
        {
            var courseDetail = await _context.Courses
                .Include(ic => ic.Instructor_Course).ThenInclude(i => i.Instructors)
                .FirstOrDefaultAsync(n => n.Id == id);

            return courseDetail;
        }

        public async Task<NewCourseDropdownVM> GetNewCourseDropdownsValues()
        {
            var response = new NewCourseDropdownVM();
            {
                response.Instructors = await _context.Instructors.OrderBy(n => n.FullName).ToListAsync();
            };
            return response;
        }

        public async Task UpdateCourseAsync(NewCoursesVM data)
        {
            var dbCourse = await _context.Courses.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbCourse != null)
            {
                dbCourse.Name = data.Name;
                dbCourse.Description = data.Description;
                dbCourse.Price = data.Price;
                dbCourse.ImageURL = data.ImageURL;
                dbCourse.Create = DateTime.Now;;
                dbCourse.CourseCategory = data.CourseCategory;
                await _context.SaveChangesAsync();
            }

            //Remove existing Instructor
            var existingInstructorDb = _context.Instructor_Course.Where(n => n.CourseId == data.Id).ToList();
            _context.Instructor_Course.RemoveRange(existingInstructorDb);
            await _context.SaveChangesAsync();

            //Add Course Instructor
            foreach (var instructorsId in data.InstructorIds)
            {
                var newInstructorCourse = new Instructor_Course()
                {
                    CourseId = data.Id,
                    InstructorId = instructorsId
                };
                await _context.Instructor_Course.AddAsync(newInstructorCourse);
            }
            await _context.SaveChangesAsync();
        }
    }
}
