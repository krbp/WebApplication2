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
        public String Yell()
        {
            return "HELLO";
        }

        [Route("/Say")]
        public String Say()
        {
            return "Hello";
        }

        public String YellHello()
        {
            return "HELLO";
        }

        public String SayHello()
        {
            return "Hello";
        }
    }
}
