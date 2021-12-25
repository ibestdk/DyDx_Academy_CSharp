using DyDx_Academy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.ViewModels
{
    public class NewCourseDropdownVM
    {
        public NewCourseDropdownVM()
        {
            Instructors = new List<Instructors>();
        }
        public List<Instructors> Instructors { get; set; }
    }
}
