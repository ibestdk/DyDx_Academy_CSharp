using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Controllers
{
    public class HTML_101Controller : Controller
    {

        [Route("Course/HTML-101")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Course/HTML-101/Basic-index-structure")]
        public IActionResult Part1()
        {
            return View();
        }
        
        [Route("Course/HTML-101/Headings-and-Paragraphs")]
        public IActionResult Part2()
        {
            return View();
        }
    }
}
