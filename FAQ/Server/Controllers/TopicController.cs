using FAQ.Server.Bussiness;
using FAQ.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FAQ.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Filter>> GetTopic()
        {
            List<Filter> topic = new();
            topic = FAQManager.GetTopic();
            return topic;
        }
    }
}
