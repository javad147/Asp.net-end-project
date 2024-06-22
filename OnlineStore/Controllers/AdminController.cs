using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Controllers
{

    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Member"))
                {
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
        }
    }
}
