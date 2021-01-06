using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNet.Controllers
{
    //public class HelloController : Controller
    //{
    //    // ATTRIBUTE ROUTING:
    //    // GET: /<controller>/
    //    //[HttpGet]               // <-- get attribute 
    //    //[Route("/helloworld/")] // route attribute,  called attribute routing || or /hello/index if conventional
    //    //public IActionResult Index()    // called action method
    //    //{
    //    //    string html = "<h1>Hello World</h1>";
    //    //    return Content(html, "text/html");
    //    //}

    //    //// GET: /<controller>/welcome --> /hello/welcome
    //    //[HttpGet]
    //    //[Route("/helloworld/welcome/{name?}")] // another example of attribute routing
    //    //public IActionResult Welcome(string name = "World")
    //    //{
    //    //    return Content("<h1> Welcome to my app, " + name + "!</h1>", "text/html");
    //    //}

    //    // FORM (to use CONVENTIONAL ROUTING, remove [Http] attribute
    //    [HttpGet]               // <-- get method attribute 
    //    [Route("/helloworld/")] // route attribute,  called attribute routing || or /hello/index if conventional
    //    public IActionResult Index()    // called action method
    //    {
    //        string html = "<form method='post' action='/helloworld/'>" + //changed from /hello/welcome after using attribute routing
    //            "<input type='text' name='name' />" +
    //            "<input type='submit' value='Greet me!' />" +
    //            "</form>";

    //        return Content(html, "text/html");
    //    }

    //    //// GET: /<controller>/welcome --> /hello/welcome
    //    [HttpPost]          // post method attribute
    //    [Route("/helloworld/")] // another example of attribute routing // changed from [Route("/helloworld/welcome/")] to run both methods on the same URL
    //    public IActionResult Welcome(string name = "World")
    //    {
    //        return Content("<h1> Welcome to my app, " + name + "!</h1>", "text/html");
    //    }
    //}

    // CLASS LEVEL ROUTING, DRYing the code - to simplify code commented out above
    [Route("/helloworld/")] // "helloworld/" also works  // since both method attributes (get and post) refer to the same route, this can be class level
    public class HelloController : Controller
    {
       
        [HttpGet]               
        public IActionResult Index()   
        {
            string html = 
                "<form method='post' action='/helloworld/'>" + 
                    "<input type='text' name='name' />" +
                    "<select name='language'>" +
                        "<option value='Hello' selected>English</option>" +
                        "<option value='Kamusta'>Tagalog</option>" +
                        "<option value='Bonjour'>French</option>" +
                        "<option value='Konnichiwa'>Japanese</option>" +
                        "<option value='Hola'>Spanish</option>" +
                        "<option value='Salamu'>Swahili</option>" +
                    "</select>" +
                    "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        //[HttpGet("welcome/{name?}")] // to make welcome method respond to both get and post 
        [HttpPost]
        public IActionResult Welcome(string language, string name = "World")
        {
            string html = language + ", " + name + "!";

            return Content(html, "text/html");
        }
    }
}
