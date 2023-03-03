using Microsoft.AspNetCore.Mvc;

namespace DotnetWebapplication.Controllers
{
    [Route("/api/[controller]")]
    public class DemoController : Controller
    {
        public OkObjectResult Index()
        {
            return Ok("Test");
        }
    }
}
