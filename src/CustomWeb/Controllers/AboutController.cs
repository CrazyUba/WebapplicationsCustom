using CustomWeb.Models;
using Microsoft.Extensions.Options;

namespace CustomWeb.Controllers
{
    public class AboutController : BaseController
    {
        public AboutController(IOptions<MyEnvOptions> myEnvOptions) : base(myEnvOptions)
        {

        }
    }
}