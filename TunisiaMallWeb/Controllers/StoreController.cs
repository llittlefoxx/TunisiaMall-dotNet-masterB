using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service;
using TunisiaMall.Service.Services;

namespace TunisiaMallWeb.Controllers
{
    public class StoreController : Controller
    {

        IStoreService s = new StoreService();


        // GET: Store
        [Route("Store/ListStore")]
        public ActionResult ListStore()
        {
           
           
            IEnumerable<store> st = s.GetMany();
            List<store> stores = st.ToList();
            
          
            return View(stores);
           
        }

        // GET
        [Route("ListStoreByCategory/{categoryName}")]
        public ActionResult ListStoreByCategory(string categoryName)
        {
            
           IEnumerable<store> stores = s.GetMany(x=> x.category.libelle.Equals(categoryName));
            List<store> storesss = stores.ToList();
      
         
            return View(storesss);

        }

        // GET: Detail
        [Route("DetailStore/{id}")]
        public ActionResult DetailStore(long id)
        {
            store st = s.FindById(id);
            return View(st);
        }

        // GET: Detail2
        [Route("DetailStoreName/{name}")]
        public ActionResult DetailStoreName(string name)
        {
            store st = s.GetStoreByName(name);
            return View(st);
        }

       
        // GET: ListStore
        [Route("ListStoreBySubCategory/{name}")]
        public ActionResult ListStoreBySubCategory(string name)
        {
            IEnumerable<store> st = s.GetStoreBySubCategory(name);
            List<store> stores = st.ToList();
            return View(stores);
        }




        // GET
        [Route("ListPromotionnelStore")]
        public ActionResult ListPromotionnelStore()
        {

            IEnumerable<store> stores = s.GetStoreByPromotionProduct();
            List<store> storesss = stores.ToList();


            return View(storesss);

        }
        // GET
        [Route("GetProductByPromotionStore/{id}")]
        public ActionResult GetProductByPromotionStore(int id)
        {

            IEnumerable<product> stores = s.GetProductByPromotionStore(id);
            List<product> storesss = stores.ToList();


            return View(storesss);

        }





        // GET: Store/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Store/Create
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

        // GET: Store/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Store/Edit/5
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

        // GET: Store/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Store/Delete/5
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
