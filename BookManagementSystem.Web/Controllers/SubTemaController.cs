using BookManagementSystem.Web.Attributes;
using System.Web.Mvc;

namespace BookManagementSystem.Web.Controllers
{
    [AuthorizeSession]
    public class SubTemaController : Controller
    {
        public ActionResult Edicion()
        {
            return View();
        }
    }
}