using DyDx_Academy.Data;
using DyDx_Academy.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Models
{
    public class Courses:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }

        public DateTime Create { get; set; }
        public CourseCategory CourseCategory { get; set; }


        //Relationships
        public List<Instructor_Course> Instructor_Course { get; set; }
    }
}
