﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Identity
{
    public class AppIdentityUser:IdentityUser
    {
        public int Age { get; set; }

    }
}
