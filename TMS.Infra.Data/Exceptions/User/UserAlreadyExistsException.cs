using System;
namespace TMS.Infra.Data.Exceptions.User
{
	public class UserAlreadyExistsException : Exception
	{
		public UserAlreadyExistsException() : base("User Already Exists")
		{

		}
	}
}

