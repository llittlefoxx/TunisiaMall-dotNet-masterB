using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;

namespace TunisiaMallWeb.Controllers
{
    public class SubCategoryController : Controller
    {
        ISubCategoryService subcateg = new SubCategoryService();



        // GET: SubCategory

        [Route("GetAllSubCategories")]
        public ActionResult GetAllSubCategories()
        {
            IEnumerable<subcategory> subcategList = subcateg.GetMany();
            List<subcategory> subcategFinalll = subcategList.ToList();
            return View(subcategFinalll);
        }



        // GET: SubCategory

        [Route("GetAllSubCategoriesByCategory")]
        public ActionResult GetAllSubCategoriesByCategory(int id)
        {
            IEnumerable<subcategory> subcategList = subcateg.GetMany(x=> x.idCategory==id);
            List<subcategory> subcategFinal = subcategList.ToList();
            return View(subcategFinal);
        }

        // GET: SubCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubCategory/Create
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

        // GET: SubCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubCategory/Edit/5
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

        // GET: SubCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubCategory/Delete/5
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
