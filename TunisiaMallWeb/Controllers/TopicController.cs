using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Service.Services;

namespace TunisiaMallWeb.Controllers
{
    public class TopicController : Controller
    {
        TopicService t = new TopicService();

        // GET: Topic
        [Route("Forum")]
        public ActionResult Index()
        {
            var topics = t.GetAllTopic();
            return View(topics);
        }
    }
}
