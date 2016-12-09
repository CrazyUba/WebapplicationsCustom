
using CustomWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CustomWeb.Controllers
{
    public class ProductsController : BaseController
    {
        public ProductsController(IOptions<MyEnvOptions> myEnvOptions):base(myEnvOptions)
        {

        }
        
    }
}