
using CustomWeb.Models;
using System.Web.Mvc;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Options;

namespace CustomWeb.Controllers
{
    public class ProductsController : BaseController
    {
        public ProductsController():base()
        {

        }

        [Authorize]
        override public ActionResult Index()
        {
            return View("Index" + base.controllerName, page);

        }

    }
}