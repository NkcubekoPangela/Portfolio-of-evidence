using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace poe_progs_3.Areas.Identity.Data;

// Add profile data for application users by adding properties to the poe_progs_3User class
public class poe_progs_3User : IdentityUser
{
    public class Module
    {
        public int fname { get; set; }
        public string LName { get; set; }
        public int password { get; set; }
       
    }
}

