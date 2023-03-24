using System;
namespace EliaGroup.API.Dtos.Users
{
	public class AuthResponse
	{
        public string? UserId { get; set; }
        public string? Token { get; set; }
        public string? Email { get; set; }
    }
}

