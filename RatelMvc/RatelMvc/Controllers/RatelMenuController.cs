using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RatelMvc.Controllers
{
    public class RatelMenuController : Controller
    {
        // GET: RatelMenu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult StartShow()
        {
            return View();
        }
    }
}