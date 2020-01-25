using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebHard.Controllers
{
    [Authorize]
    public class CooperativeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Manpower()
        {
            return View();
        }

        // GET: Cooperative/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cooperative/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cooperative/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cooperative/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cooperative/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cooperative/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AdminPage() 
        {
            return View();
        }
    }
}