using DyDx_Academy.Data.Services;
using DyDx_Academy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly IInstructorsService _service;

        public InstructorsController(IInstructorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Instructors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Instructors instructors)
        {
            if (!ModelState.IsValid)
            {
                return View(instructors);
            }
            await _service.AddAsync(instructors);
            return RedirectToAction(nameof(Index));
        }


        //Get: Actors/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var instructorsDetails = await _service.GetByIdAsync(id);

            if (instructorsDetails == null) return View("NotFound");
            return View(instructorsDetails);
        }

        //Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var instructorsDetails = await _service.GetByIdAsync(id);
            if (instructorsDetails == null) return View("NotFound");
            return View(instructorsDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Instructors instructors)
        {
            if (!ModelState.IsValid)
            {
                return View(instructors);
            }
            await _service.UpdateAsync(id, instructors);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var instructorsDetails = await _service.GetByIdAsync(id);
            if (instructorsDetails == null) return View("NotFound");
            return View(instructorsDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instructorsDetails = await _service.GetByIdAsync(id);
            if (instructorsDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
