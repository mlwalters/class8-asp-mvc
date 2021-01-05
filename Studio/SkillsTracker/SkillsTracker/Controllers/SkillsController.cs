using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult Index()
        {
            string html =
               "<form method = 'post' action = '/skills/form'>" +
                    "<label> Date: <br>" +
                         "<input type ='date' name ='learningDate'>" +
                    "</label><br><br>" +
                    "<label> C#: <br>" +
                         "<select name ='csharpProgress'>" +
                            "<option value ='Learning basics'> Learning basics </option>" +
                            "<option value = 'Making apps' > Making apps </option>" +
                            "<option value = 'Master coder' > Master coder </option>" +
                        "</select>" +
                    "</label><br><br>" +
                    "<label> JavaScript: <br>" +
                         "<select name ='jsProgress'>" +
                            "<option value ='Learning basics'> Learning basics </option>" +
                            "<option value = 'Making apps' > Making apps </option>" +
                            "<option value = 'Master coder' > Master coder </option>" +
                        "</select>" +
                    "</label><br><br>" +
                    "<label> Python: <br>" +
                         "<select name ='pythonProgress'>" +
                            "<option value ='Learning basics'> Learning basics </option>" +
                            "<option value = 'Making apps' > Making apps </option>" +
                            "<option value = 'Master coder' > Master coder </option>" +
                        "</select>" +
                    "</label><br><br>" +
                    "<label>" +
                        "<input type = 'submit' value = 'Submit' />" +
                    "</label>" +
                "</form>";
          
            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/form")]
        public IActionResult Form(string learningDate, string csharpProgress, string jsProgress, string pythonProgress)
        {
            string html =
                "<h1>As of today (" + learningDate + "):<br></h1>" +
                "<ol>" +
                    "<li>C#: " + csharpProgress + "</li><br>" +
                    "<li>JavaScript: " + jsProgress + "</li><br>" +
                    "<li>Python: " + pythonProgress + "</li><br>" +
                "</ol>";
            return Content(html, "text/html");
        }

    }
}
