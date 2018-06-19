using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tanasuk.Models;
using Tanasuk.Business;

namespace Tanasuk.Controllers
{
    public class TanasukController : Controller
    {
        // GET: Tanasuk
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Navigation()
        {
            Navigation _nav = new Navigation();
            return View(_nav.Navi());
        }
        public ActionResult Side()
        {
            Navigation _nav = new Navigation();
            return View(_nav.Navi());
        }
        public ActionResult Adv()
        {
            return View(IMedia.Source());
        }
    }
}