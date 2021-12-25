using DyDx_Academy.Models;
using Microsoft.AspNetCore.Mvc;

namespace DyDx_Academy.Data.ViewComponents
{
    public class AccountAC : ViewComponent
    {
        private readonly ApplicationUser _userData;
        public AccountAC(ApplicationUser userData)
        {
            _userData = userData;
        }

        public IViewComponentResult Invoke()
        {
            var items = _userData.Credit;

            return View();
        }
    }
}
