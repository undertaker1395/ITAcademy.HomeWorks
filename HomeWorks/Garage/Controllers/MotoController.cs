using Garage.BL;
using Garage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage.Controllers
{
    public class MotoController : Controller
    {
        readonly IMotoRepository _motoRepository;

        public MotoController()
        {
            _motoRepository = new MotoListRepository();
        }

        // GET: MotoController
        public ActionResult Index()
        {
            List<Moto> collection = _motoRepository.GetMotorcycles();

            return View(collection);
        }

        // GET: MotoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MotoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MotoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Moto moto)
        {
            try
            {
                _motoRepository.CreateMotorcycle(moto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MotoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MotoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Moto moto)
        {
            try
            {
                _motoRepository.UpdateMotorcycle(moto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MotoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MotoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Moto moto)
        {
            try
            {
                _motoRepository.DeleteMotorcycle(moto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
