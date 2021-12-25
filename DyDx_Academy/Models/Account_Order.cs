using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.Models
{
    public class Account_Order
    {
        [Key]
        public int Id { get; set; }

        public int UsersId { get; set; }
        public ApplicationUser ApplicationUsers { get; set; }



        public int OrderId { get; set; }
        public Order Orders { get; set; }
    }
}
