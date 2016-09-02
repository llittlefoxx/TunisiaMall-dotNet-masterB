using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;
using TunisiaMallWeb.Logic;

namespace TunisiaMallWeb.Controllers
{
    public class PostController : Controller
    {
        TopicService t = new TopicService();
        PostService p = new PostService();
        // GET: Post
        [Route("Forum/{idTopic}")]
        public ActionResult Index(int idTopic)
        {
            ViewBag.idUser = 0;
            if (CurrentUser.get() != null)
            {
                ViewBag.idUser = CurrentUser.get().idUser;
            }
            ViewBag.idTopic = idTopic;
            var posts = p.GetPostByTopic(idTopic);
            return View(posts);
        }
        //GEt: Detail
        [Route("DetailPost/{id}")]
        public ActionResult DetailPost(int id)
        {
            post post = p.GetPost(id);
            return View(post);
        }
        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Post/Create
        public ActionResult Create(int idTopic)
        {
            ViewBag.idTopic = idTopic;
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(int idTopic, post post)
        {
            post.user = CurrentUser.get();
            post.topic = t.FindById(idTopic);
            post.postDate = DateTime.Now;
            p.Create(post);
            p.Commit();

            return RedirectToAction("Index", new { idTopic = post.idTopic });
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            post p1 = p.FindById(id);

            return View(p1);
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(post p1)
        {

            post p2 = p.FindById(p1.idPost);
            p2.description = p1.description;
            p2.title = p1.title;
            p.Update(p2);
            p.Commit();
            return RedirectToAction("Index", new { idTopic = p1.idTopic });

        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            post post = p.GetPost(id);
            return View(post);
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, post post)
        {

            post p1 = p.FindById(id);
            p.Delete(p1);
            p.Commit();

            return RedirectToAction("Index", new { idTopic = post.idTopic });


        }
    }
}
