using AspNetCoreMvcIntroduction.Entities;
using AspNetCoreMvcIntroduction.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Controllers
{
    public class SessionDemoController : Controller
    {
        public string Index()
        {
            HttpContext.Session.SetInt32("age", 32);
            HttpContext.Session.SetString("name","Burak");
            HttpContext.Session.SetObject("student",new Student
            {
                Email = "burakdogan@gmail.com",
                FirstName = "burak",
                LastName = "doğan",
                Id = 1,
            });
            return "SessionCreated";
        }

        public string GetSessions()
        {

            return string.Format("Hello {0}", "you are {1}. Student is {2}", HttpContext.Session.GetString("name"), HttpContext.Session.GetInt32("age"),HttpContext.Session.GetObject<Student>("student").FirstName);
        }
    }
}
