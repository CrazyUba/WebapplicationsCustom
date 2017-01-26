using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
using CustomWeb.Models;
using CustomWeb.Controllers;
using System.Web.Mvc;
//using Microsoft.Extensions.Options;

namespace CustomWeb2.Controllers
{

    public class HomeController : BaseController
    {
        public HomeController():base()
        {

        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult NewPage()
        //{
        //    ViewData["Message"] = "Yeah, that's a new page.";

        //    return View();
        //}

        public ActionResult Error()
        {
            return View();
        }
    }
}
