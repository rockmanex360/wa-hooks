using Microsoft.AspNetCore.Mvc;

namespace WAHooks.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : Controller
    {
        public DefaultController()
        {}

        [HttpGet]
        public string GetDefaultRoute()
        {
            return "Success";
        }
    }
}