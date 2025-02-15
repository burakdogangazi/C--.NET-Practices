﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "First Name")] 
        //Data Formlarda First Name adında space ile gözükür.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }

    }
}
