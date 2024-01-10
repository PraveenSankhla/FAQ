using FAQ.Server.Bussiness;
using FAQ.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FAQ.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FAQController : ControllerBase
    {
        [HttpPost]
        public async Task<List<FAQs>> GetFAQData(FAQs faq)
        {
            List<FAQs> fAQs = new();
            fAQs = FAQManager.GetFAQ(faq);
            return fAQs;
        }
    }
}