using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LoginAndRegistration.Models
{
    public class ApplicationUser:IdentityUser
    {
        
        public string Name { get; set; }
        
        public DateTime DOB { get; set; }

        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
