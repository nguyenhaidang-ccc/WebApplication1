using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Message = "Message from ViewBag";

            ViewBag.CurrentTime = DateTime.Now;
            return View();
        }
    }
}