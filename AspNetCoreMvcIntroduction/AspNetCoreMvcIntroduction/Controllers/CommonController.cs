using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Controllers
{
    public class CommonController : Controller
    {
        [Route("/error")]
        public IActionResult Index()
        {
            return View(); // view oluştuurp içine cshtml yazarız hata gelince burayar routeolur oraya gider.
        }
    }
}
