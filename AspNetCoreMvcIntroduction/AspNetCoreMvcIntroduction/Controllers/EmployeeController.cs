﻿using AspNetCoreMvcIntroduction.Entities;
using AspNetCoreMvcIntroduction.Models;
using AspNetCoreMvcIntroduction.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Controllers
{
    public class EmployeeController : Controller
    {
        private ICalculator _calculator;
        public EmployeeController(ICalculator calculator)
        {
            _calculator = calculator;
        }
        public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text = "Ankara",Value = "6"},
                    new SelectListItem{Text = "İstanbul",Value = "34"}
                }
            };
            return View(employeeAddViewModel);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            //Butona basınca employee buraya gelir
            //veri tabanı işlemleri yapılabilir
            return View();
        }

        public string Calculate()
        {
            return _calculator.Calculate(100).ToString();
        }
    }     
}
