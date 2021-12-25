using DyDx_Academy.Data.Base;
using DyDx_Academy.Models;
using DyDx_Academy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Data.Services
{
    public interface ICourseService : IEntityBaseRepository<Courses>
    {
        Task<Courses> GetCoursesByIdAsync(int id);
        Task<NewCourseDropdownVM> GetNewCourseDropdownsValues();
        Task AddNewCourseAsync(NewCoursesVM data);
        Task UpdateCourseAsync(NewCoursesVM data);
    }
}
