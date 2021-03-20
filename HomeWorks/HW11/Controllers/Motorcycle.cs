using HW11.BL;
using HW11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW11.Controllers
{
    public class Motorcycle : Controller
    {
        readonly IMotorcycleRepository _motorcycleRepository;

        public Motorcycle()
        {
            _motorcycleRepository = new MotorcycleListRepository();
        }
        // GET: Motorcycle
        public ActionResult Index()
        {
            List<Moto> collection = new List<Moto>();

            return View(collection);
        }

        // GET: Motorcycle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Motorcycle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motorcycle/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Moto moto)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Motorcycle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Motorcycle/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Motorcycle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Motorcycle/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
