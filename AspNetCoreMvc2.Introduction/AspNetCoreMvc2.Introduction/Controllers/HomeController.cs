using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    //[Controller]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

// http://burakdogan.com/home/index
// home da home controllerdan instance oluşturuyor.
//HomeController h = new HomeController()
// h.Index();
