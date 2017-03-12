using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial3.Models;

namespace Tutorial3.Controllers
{
    public class CarsController : Controller
    {
        private CarDBCtxt dbcars = new CarDBCtxt();
        // GET: Cars
        public ActionResult Index()
        {
            ViewData["tytyl"] = "Tytuł";
            ViewData["liczba"] = 1;

            ViewBag.tytul2 = "Tytyuł2";
            ViewBag.liczba2 = 2;

            Car thing = new Car();
            thing.id = 22;

            return View(dbcars.Cars.ToList());
        }

        //GET: /Cars/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: /Cars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="Id,Brand,Model,Price,Bought,Sold")] Car car)
        {
            if (ModelState.IsValid)
            {
                dbcars.Cars.Add(car);
                dbcars.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(car);
        }
    }
}