﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Filters
{
    public class CustomFilter : Attribute, IActionFilter
    {

        public void OnActionExecuting(ActionExecutingContext context)
        {
            int i = 10;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            int i = 20;
        }
   
    }
}
