using BookManagementSystem.Web.Attributes;
using System.Web.Mvc;

namespace BookManagementSystem.Web.Controllers
{
    [AuthorizeSession]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}