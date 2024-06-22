using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;

namespace OnlineStore.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly OnlineStoreContext _context;

        public UserController(OnlineStoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.IsInRole("SuperAdmin"))
            {

                List<OnlineStore.Areas.Identity.Data.OnlineStoreUser> model = _context.Users.ToList();
                return View(model);
            }
            else
            {
                return RedirectToAction("Index","Admin");
            }
        }
    }
}
