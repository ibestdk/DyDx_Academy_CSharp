using DyDx_Academy.Data.Base;
using DyDx_Academy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Data.Services
{
    public class InstructorsService : EntityBaseRepository<Instructors>, IInstructorsService
    {

        public InstructorsService(ApplicationDbContext context) : base(context) { }
        
    }
}
