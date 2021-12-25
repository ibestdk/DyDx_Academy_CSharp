using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Models
{
    public class Instructor_Course
    {
        public int CourseId { get; set; }
        public Courses Courses { get; set; }




        public int InstructorId { get; set; }
        public Instructors Instructors { get; set; }
    }
}
