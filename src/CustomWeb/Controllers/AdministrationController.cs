using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomWeb.Models;
using Microsoft.Extensions.Options;

namespace CustomWeb.Controllers
{

    public class AdministrationController : BaseController
    {
        public AdministrationController(IOptions<MyEnvOptions> myEnvOptions):base(myEnvOptions)
        {

        }

        
        public IActionResult Error()
        {
            return View();
        }
    }
}
