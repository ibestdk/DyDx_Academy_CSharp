using DyDx_Academy.Data;
using DyDx_Academy.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Models
{
    public class NewCoursesVM
    {
        public int Id { get; set; }

        [Display(Name = "Course name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Display(Name = "ราคา บาท")]
        [Required(ErrorMessage = "กรุณาระบุราคา")]
        public double Price { get; set; }
        [Display(Name = "Course image")]
        [Required(ErrorMessage = "Course image is required")]
        public string ImageURL { get; set; }

        public DateTime Create { get; set; }
        [Display(Name = "Course Category")]
        [Required(ErrorMessage = "Course Category is required")]
        public CourseCategory CourseCategory { get; set; }


        //Relationships
        [Display(Name = "Select Instructor")]
        [Required(ErrorMessage = "Select Instructor is required")]
        public List<int> InstructorIds { get; set; }
    }
}
