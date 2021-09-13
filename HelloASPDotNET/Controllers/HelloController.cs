using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/hello")]
        public IActionResult Welcome(string name = "World", string language = "English")
        {
            /*if(language == "English")
            {
                return Content("<h1>Hello, " + name + "!</h1", "text/html");
            } else if (language == "Spanish")
            {
                return Content("<h1>Hola, " + name + "!</h1", "text/html");
            } else if (language == "French")
            {
                return Content("<h1>Bonjour, " + name + "!</h1", "text/html");
            } else if (language == "Swahili")
            {
                return Content("<h1>Habari, " + name + "!</h1", "text/html");
            } else if (language == "German")
            {
                return Content("<h1>Hallo, " + name + "!</h1", "text/html");
            }
            else
            {
                return Content("<h1></h1>", "text/html");
            }*/

            ViewBag.person = name;
            ViewBag.language = language;
            return View();
        }

        /*GET: hello/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }*/
    }
}
