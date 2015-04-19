using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScratchMVC.Models;

namespace ScratchMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            int id = 1337;
            return View(model: id);
        }

        [HttpPost]
        public ActionResult PostData(PostDataViewModel model)
        {
            //Another form of receiving input
            return View(model);
        }
    }
}