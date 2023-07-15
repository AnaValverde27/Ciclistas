using Ciclistas.Models;
using Ciclistas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ciclistas.Controllers
{
    public class HomeController : Controller
    {
        CiclistasRepository rep = new CiclistasRepository();
        public ActionResult Index()
        {
            IEnumerable<Ciclista> obj = rep.SelectAllCiclistas();
            return View(obj);
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Create(Ciclista cicli)
        {
            try
            {
                rep.InsertCiclistas(cicli);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int Id)
        {
            Ciclista obj = rep.SelectCiclistasById(Id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(int id, Ciclista cicli)
        {
            try
            {
                // Convertir el tiempo total a segundos
                double tiempoSegundos = cicli.Tiempo.TotalSeconds;

                // Calcular la velocidad en metros por segundo
                double distanciaMetros = 12000; // 12 kilómetros en metros
                double velocidadMetrosPorSegundo = distanciaMetros / tiempoSegundos;

                // Actualizar la propiedad 'Metros' en el modelo con la velocidad calculada
                cicli.Metros = velocidadMetrosPorSegundo;

                rep.UpdateCiclistas(cicli);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}