using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : Controller
    {
        public ActionResult Index()
        {
            return View("View1");
        }

        public ActionResult View1()
        {
            return View();
        }

        public ActionResult View2()
        {
            return PartialView();
        }

        // TODO 錯誤示範：千萬不要將 JavaScript 寫在 Controller 裡面
        public ActionResult Content1()
        {
            return Content("<script>alert('OK'); location.href='/';</script>", "text/html");
        }

    }
}