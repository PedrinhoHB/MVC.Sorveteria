using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Sorveteria.Controllers
{
    public class SorveteController : Controller
    {
        // GET: Sorvete
        public ActionResult Index()
        {
            return View();
        }
    }
}