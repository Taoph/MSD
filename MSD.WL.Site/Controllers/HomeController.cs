using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSD.WL.Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "欢迎使用财务管理系统";
            return View();
        }

        public ActionResult Top()
        {
            ViewBag.UserName = "超级管理员";
            ViewBag.AvailableBalance = "8888.00";
            return View();
        }

        public ActionResult Left()
        {
            return View();
        }

        public ActionResult Right()
        {
            return View();
        }
    }
}