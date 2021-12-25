using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Controllers
{
    public class CSS_101Controller : Controller
    {

        [Route("Course/CSS-101")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Course/CSS-101/Start-write-css")]
        public IActionResult Part1()
        {
            return View();
        }
        
        [Route("Course/CSS-101/Syntax-and-Selector")]
        public IActionResult Part2()
        {
            return View();
        }

         [Route("Course/CSS-101/CSS-Colors")]
        public IActionResult Part3()
        {
            return View();
        }

         [Route("Course/CSS-101/CSS-Background")]
        public IActionResult Part4()
        {
            return View();
        }

         [Route("Course/CSS-101/CSS-Border")]
        public IActionResult Part5()
        {
            return View();
        }

         [Route("Course/CSS-101/Margins")]
        public IActionResult Part6()
        {
            return View();
        }

         [Route("Course/CSS-101/Padding")]
        public IActionResult Part7()
        {
            return View();
        }


    }
}
