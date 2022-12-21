using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiziFilm.Controllers
{
    public class FilmlerController : Controller
    {
        public ActionResult Filmler()
        {
            return View();
        }
    }
}