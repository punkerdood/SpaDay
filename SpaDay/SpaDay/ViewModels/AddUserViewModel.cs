using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is desired")]
        [StringLength(15, MinimumLength = 5)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is wanted")]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        [EmailAddress] 
        public string Email {get; set; }



        }
}
