﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakariaBookstore.Models
{
    public class webuser :IdentityUser
    {

        [PersonalData]
        public string Name { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

    }
}
