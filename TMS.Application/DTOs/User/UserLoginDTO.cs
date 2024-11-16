using System;
using System.ComponentModel.DataAnnotations;
using TMS.Domain.Core;

namespace TMS.Application.DTOs.User
{
	public static class UserLoginDTO
	{
		public class Input
		{
			[Required]
			[EmailAddress(ErrorMessage = "Email is invalid.")]
			public required string Email { get; set; }

			[Required]
			[MinLength(6, ErrorMessage = "Password needs to be greater than 6.")]
			public required string Password { get; set; }
		}

		public class Output : StandardResponse
		{
			public required string Token { get; set; }
		}
	}
}

