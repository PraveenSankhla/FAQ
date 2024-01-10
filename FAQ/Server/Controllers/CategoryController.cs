using FAQ.Server.Bussiness;
using FAQ.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FAQ.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Filter>> GetCategoryData()
        {
            List<Filter> Category = new();
            Category = FAQManager.GetCategory();
            return Category;
        }
    }
}
