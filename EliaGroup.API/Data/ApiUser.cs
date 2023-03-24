using System;
using Microsoft.AspNetCore.Identity;

namespace EliaGroup.API.Data
{
	public class ApiUser:IdentityUser
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
	}
}


