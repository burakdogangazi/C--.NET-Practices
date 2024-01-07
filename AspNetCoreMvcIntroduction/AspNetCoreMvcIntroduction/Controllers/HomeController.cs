using AspNetCoreMvcIntroduction.Entities;
using AspNetCoreMvcIntroduction.Filters;
using AspNetCoreMvcIntroduction.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Controllers
{
    //[Controller] tagi ile de kullanılabilir
    public class HomeController : Controller
    {
        public string Index()
        {
            return "first app";
        }

        [HandleException(ViewName ="DivideByZeroError",ExceptionType =typeof(DivideByZeroException))]
        [HandleException(ViewName = "Error", ExceptionType = typeof(SecurityException))]
        public ViewResult Index2()
        {
            throw new DivideByZeroException();
            return View();
            //index2 çlışırsa view döner kullanıcının gördüğü html css js gözükür
        }

        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 1,FirstName="Burak",LastName = "Doğan",CityId=6 },
                new Employee {Id = 2,FirstName="Metin",LastName = "Doğan",CityId=7 },
                new Employee {Id = 3,FirstName="Aziz",LastName = "Doğan",CityId=9 },
            };

            List<string> cities = new List<string> { "İstanbul", "Ankara" };
            // 2 model eklenemiyor 

            // 2 listeyi sarmalaayıp tekmodel yaparız 

            var model = new EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities,
            };

            return View(model);

        }

        public IActionResult Index4()
        {
            return StatusCode(200); // 200 sıkıntı değil
            //Return Ok();

        }

        public StatusCodeResult Index5()
        {
            return StatusCode(400); // bad request
            //return BadRequest();
            //return NotFound();

        }
        //HTTp yapıldığında istek 404 veya navigate .. bad request gibi hatalarda bu sonuçları döndürür apilerde olmalı
        //statuscode result

        public RedirectResult Index6()
        {//IActionResult ta dönebilir
            return Redirect("/Home/Index3");
        }

        public IActionResult Index7()
        {//IActionResult ta dönebilir
            return RedirectToAction("Index2");
            //Yukarıya göre daha yaygın kullanım
        }

        public IActionResult Index8()
        {
            return RedirectToRoute("default");
            //mevcute çalıştığımız aksiyonu bu route göre çalıştır.
        }

        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 1,FirstName="Burak",LastName = "Doğan",CityId=6 },
                new Employee {Id = 2,FirstName="Metin",LastName = "Doğan",CityId=7 },
                new Employee {Id = 3,FirstName="Aziz",LastName = "Doğan",CityId=9 },
            };

            return Json(employees);
        }

        public IActionResult RazorDemo()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 1,FirstName="Burak",LastName = "Doğan",CityId=6 },
                new Employee {Id = 2,FirstName="Metin",LastName = "Doğan",CityId=7 },
                new Employee {Id = 3,FirstName="Aziz",LastName = "Doğan",CityId=9 },
            };

            List<string> cities = new List<string> { "İstanbul", "Ankara" };
            // 2 model eklenemiyor 

            // 2 listeyi sarmalaayıp tekmodel yaparız 

            var model = new EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities,
            };

            return View(model);
        }

        public JsonResult Index10(string key)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 1,FirstName="Burak",LastName = "Doğan",CityId=6 },
                new Employee {Id = 2,FirstName="Metin",LastName = "Doğan",CityId=7 },
                new Employee {Id = 3,FirstName="Aziz",LastName = "Doğan",CityId=9 },
            };

            if (String.IsNullOrEmpty(key))
            {
                return Json(employees);
            }

            var result = employees.Where(e => e.FirstName.ToLower().Contains(key));

            return Json(result);
        }

        public ViewResult EmployeeForm()
        {

            return View();
        }

        public string RouteData(int id)
        {
            return id.ToString();
        }
    }
}

//http://burakdogan.com/home/index
// home controllerdan instance oluşturur
//HomeController h = new HomeController()
// index h.Index();