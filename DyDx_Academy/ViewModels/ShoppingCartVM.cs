using DyDx_Academy.Data.Cart;
using DyDx_Academy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyDx_Academy.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}
