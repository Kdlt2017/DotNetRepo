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
    public class ProductController : Controller
    {
        //Calling on the service to consume the prepared
        //functionalities
        IProductService MyService;
        public ProductController()
        {
            MyService = new ProductService();
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductVM pr)
        {
            //Instantiated a product to convert the
            //ProductVM(Product View Model) into a product
            //So as to add the product into the database
            /*Known as an explicit conversion*/
            Product prod = new Product() {
                DateProd = pr.DateProd,
                Description = pr.Description,
                Name = pr.Name,
                Price = pr.Price,
                Quantity = pr.Quantity,
                ImageUrl2 = pr.ImageUrl2
            };
            MyService.AddProduct(prod);
            
           
                return View();
            
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
