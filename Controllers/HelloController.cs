using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Yell")]
        public String YellHello()
        {
            return "HELLO";
        }

        [Route("/Say")]
        public String SayHello()
        {
            return "Hello";
        }
    }
}
