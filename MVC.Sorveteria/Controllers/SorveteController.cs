using MVC.Sorveteria.Models;
using MVC.Sorveteria.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Sorveteria.Controllers
{
    public class SorveteController : Controller
    {
        private UnityOfWork _unit = new UnityOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Sorvete sorvete)
        {
            _unit.SorveteRepository.Cadastrar(sorvete);
            _unit.Salvar();
            TempData["msg"] = "Sorvete cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}