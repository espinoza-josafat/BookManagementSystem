using BookManagementSystem.Web.Attributes;
using System.Web.Mvc;

namespace BookManagementSystem.Web.Controllers
{
    [AuthorizeSession]
    public class LibroController : Controller
    {
        public ActionResult Consulta()
        {
            return View();
        }

        public ActionResult Edicion(long? isbn = null)
        {
            if (isbn.HasValue)
                ViewBag.ISBN = isbn.Value;

            return View();
        }
    }
}