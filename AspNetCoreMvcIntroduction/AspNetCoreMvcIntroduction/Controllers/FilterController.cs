using AspNetCoreMvcIntroduction.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Controllers
{
    public class FilterController : Controller
    {
        [CustomFilter]
        //executing
        public IActionResult Index()
        {
            return View();
        }
        //executed
    }
}
