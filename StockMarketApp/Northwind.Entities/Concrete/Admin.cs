﻿using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.Concrete
{
    public class Admin:IEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
