using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;

namespace TunisiaMallWeb.Controllers
{
    public class CategoryController : Controller
    {

        ICategoryService categ = new CategoryService();
        // GET: Category
        [Route("GetAllCategories")]
        public ActionResult GetAllCategories()
        {
            IEnumerable<category> categList = categ.GetMany();
            List<category> categFinal = categList.ToList();
            return View(categFinal);
        }

        // GET: Category
        [Route("GetAllCategoriesList")]
        public ActionResult GetAllCategoriesList()
        {
            IEnumerable<category> categList = categ.GetMany();
            List<category> categFinal = categList.ToList();
            return View(categFinal);
        }

        // GET: Category/Details/5
        [Route("GetCategoryDetail")]
        public ActionResult GetCategoryDetail(int id)
        {
            category cat= categ.FindById(id);
            return View(cat);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
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

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
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

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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
