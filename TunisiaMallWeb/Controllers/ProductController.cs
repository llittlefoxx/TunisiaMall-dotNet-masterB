using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;
using TunisiaMallWeb.Logic;
using TunisiaMallWeb.Models;

namespace TunisiaMallWeb.Controllers
{
    public class ProductController : Controller
    {
        ProductService ps = new ProductService();
        OrderService os = new OrderService();
        // GET: Product
        public ActionResult Index()
        {
            List<product> origin = ps.getAll().ToList();
            return View(origin);
        }
        [HttpPost]
        public ActionResult Index(string searchString)
        {
            return View(ps.findByLibelle(searchString));
        }


        public ActionResult AddToCart(int id)
        {
            ShoppingCartActions shopping = new ShoppingCartActions();
            orderline or = new orderline { idProduct_fk = id, qte = 1 };
            shopping.addToCart(or);
            foreach (var item in shopping.getCurrentSessionOrderLines())
            {
                System.Diagnostics.Debug.WriteLine(" order lines"+item.idProduct_fk + "  "+item.qte);
            }
            return RedirectToAction("Index");

        }
        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            
            return View(ps.FindById(id));
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
