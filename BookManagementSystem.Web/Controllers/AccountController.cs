using System.Web.Mvc;

namespace BookManagementSystem.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}