using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Username is required")]
        public required string Username {get; set;}

        [Required(ErrorMessage = "Password is required")]
        public required string Password {get; set;}
    }
}