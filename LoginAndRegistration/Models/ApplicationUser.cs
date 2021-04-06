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
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }

        public string Address { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
