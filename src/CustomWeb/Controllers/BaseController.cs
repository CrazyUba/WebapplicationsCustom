using Microsoft.AspNetCore.Mvc;
using WebPageRepo;
using WebPageCommon;
using Microsoft.Extensions.Options;
using CustomWeb.Models;

namespace CustomWeb.Controllers
{
    public class BaseController : Controller
    {

        private WebPage page;
        private string controllerName => this.GetType().Name + "View";
        private string customerName;


        public BaseController(IOptions<MyEnvOptions> myEnvOptions)
        {
            customerName = myEnvOptions.Value.CustomerName; // for future use
            //IRepository repo = new RepoJson(controllerName);
            IRepository repo = new RepoDb(webSiteName: "test.de");
            page = repo.GetPageBy(webPageName: controllerName);
        }


        public virtual IActionResult Index()
        {
            return View("Index" + controllerName, page);
            
        }
    }
}