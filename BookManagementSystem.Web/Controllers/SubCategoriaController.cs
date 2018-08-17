﻿using BookManagementSystem.Web.Attributes;
using System.Web.Mvc;

namespace BookManagementSystem.Web.Controllers
{
    [AuthorizeSession]
    public class SubCategoriaController : Controller
    {
        public ActionResult Edicion()
        {
            return View();
        }
    }
}