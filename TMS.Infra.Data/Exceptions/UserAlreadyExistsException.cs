using System;
namespace TMS.Infra.Data.Exceptions
{
	public class UserAlreadyExistsException : Exception
	{
		public UserAlreadyExistsException() : base("User Already Exists")
		{

		}
	}
}

