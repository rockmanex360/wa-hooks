using Microsoft.AspNetCore.Mvc;
using WAHooks.DTOs;

namespace WAHooks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WhatsAppController : ControllerBase
    {
        public WhatsAppController()
        {}

        [HttpGet("webhooks")]
        public WebHookRequest Authentication([FromQuery] WebHookRequest request)
        {
            return request;
        }
    }
}
