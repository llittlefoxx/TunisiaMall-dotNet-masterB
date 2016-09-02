using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;

namespace TunisiaMallWeb.Controllers
{
    public class PointsController : Controller
    {
        // GET: Points
        public void Index()
        {
            customer u = new customer { idUser = 1 };
            // PointsService ps = new PointsService();
            // test the addPointsToCustomer method //  OK
            //ps.addPointsToCustomer(u, 3);
            // test the removePointsFromCustomer method //  OK
            //ps.removePointsFromCustomer(u, 6);
            //return View();
            // test  method //  OK
            //ps.getBestClient(2);
            //order o = new order { idUser = u.idUser, orderStatus = "pending", cardHolder = "dali" };
           // OrderService os = new OrderService();
            //os.createOrder(o);
            //Console.Beep();

        }

        // GET: Points/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Points/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Points/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Points/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Points/Edit/5
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

        // GET: Points/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Points/Delete/5
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
