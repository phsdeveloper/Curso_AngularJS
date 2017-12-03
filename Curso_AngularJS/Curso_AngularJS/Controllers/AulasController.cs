using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curso_AngularJS.Controllers
{
    public class AulasController : Controller
    {
        // GET: Aulas
        public ActionResult Index()
        {
            return View();
        }
    }
}