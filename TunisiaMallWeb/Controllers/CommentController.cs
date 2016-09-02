using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Service.Services;
using TunisiaMall.Domain.Entities;
using TunisiaMallWeb.Logic;

namespace TunisiaMallWeb.Controllers
{
    public class CommentController : Controller
    {
        CommentService c = new CommentService();
        PostService p = new PostService();
        // GET: Comment
        public ActionResult Index(int idPost)
        {
            return PartialView();
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // POST: Comment/Create
        [HttpPost]
        public ActionResult Create(int idPost, string text)
        {
            comment c1 = new comment();
            post p1 = p.FindById(idPost);
            c1.post = p1;
            c1.text = text;
            c1.commentDate = DateTime.Now;
            c1.user = CurrentUser.get();
            c.Create(c1);
            c.Commit();
            return RedirectToAction("DetailPost", "Post", new { id = c1.idPost });
        }

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            comment c1 = c.FindById(id);
            return View(c1);
        }

        // POST: Comment/Edit/5
        [HttpPost]
        public ActionResult Edit(comment c1)
        {

            comment c2 = c.FindById(c1.idComment);
            c2.text = c1.text;
            c.Update(c2);
            c.Commit();

            return RedirectToAction("DetailPost", "Post", new { id = c2.idPost });

        }

        // GET: Comment/Delete/5
        public ActionResult Delete(int id)
        {
            comment c1 = c.FindById(id);
            return View(c1);
        }

        // POST: Comment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, comment comment)
        {
            comment c2 = c.FindById(id);
            c.Delete(c2);
            c.Commit();

            return RedirectToAction("DetailPost", "Post", new { id = c2.idPost });

        }
    }
}
