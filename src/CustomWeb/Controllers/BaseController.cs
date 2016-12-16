using Microsoft.AspNetCore.Mvc;
using WebPageRepo;
using WebPageCommon;
using Microsoft.Extensions.Options;
using CustomWeb.Models;

namespace CustomWeb.Controllers
{
    public class BaseController : Controller
    {

        private CustomPage page;
        private string controllerName => this.GetType().Name;
        private string customerName;


        public BaseController(IOptions<MyEnvOptions> myEnvOptions)
        {
            customerName = myEnvOptions.Value.CustomerName; // for future use
            RepoJson repo = new RepoJson(controllerName);
            page = repo.GetPage();
        }


        public virtual IActionResult Index()
        {
            return View("Index" + controllerName, page);
            
        }
    }
}