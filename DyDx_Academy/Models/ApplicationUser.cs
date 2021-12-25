using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace DyDx_Academy.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }

        public string FullName { get; set; }
        public string ImageUrl { get; set; }

        public int Credit { get; set; }



        public List<Order> Order { get; set; }

        internal object GetUserId(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
