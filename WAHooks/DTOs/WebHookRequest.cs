using Microsoft.AspNetCore.Mvc;

namespace WAHooks.DTOs
{
    public class WebHookRequest
    {
        [FromQuery(Name = "hub.mode")]
        public string Mode { get; set; }
        [FromQuery(Name = "hub.challenge")]
        public int Challenge { get; set; }
        [FromQuery(Name = "hub.verify_token")]
        public string VerifyToken { get; set; }
    }
}
