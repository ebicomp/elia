using System;
using System.ComponentModel.DataAnnotations;

namespace EliaGroup.API.Dtos.Users
{
	public class LoginUserDto
	{
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}

