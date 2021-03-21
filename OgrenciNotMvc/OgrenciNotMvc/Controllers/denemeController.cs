using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotMvc.Controllers
{
    public class denemeController : Controller
    {
        // GET: deneme
        public ActionResult denemeler()
        {
            return View();
        }
    }
}