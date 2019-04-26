using MyFinance.Domain.Entities;
using MyFinance.Presentation.Models;
using MyFinance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinance.Presentation.Controllers
{
    public class ProviderController : Controller
    {

        IProviderService service;
        public ProviderController()
        {
            service = new ProviderService();
        }
        // GET: Provider
        public ActionResult Index()
        {
            return View();
        }

        // GET: Provider/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Provider/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Provider/Create
        [HttpPost]
        public ActionResult Create(ProviderVM pr)
        {
            Provider prov = new Provider()
            {
                ConfirmPassword = pr.ConfirmPassword,
                DateCreated = pr.DateCreated,
                Email = pr.Email,
                Password = pr.Password,
                Username = pr.Username
            };

            service.AddProvider(prov);
                return View();
            
        }

        // GET: Provider/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Provider/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Provider/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Provider/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
