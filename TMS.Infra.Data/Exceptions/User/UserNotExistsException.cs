using System;
namespace TMS.Infra.Data.Exceptions.User
{
	public class UserNotExistsException : Exception
	{
		public UserNotExistsException() : base("User not Exists")
		{
		}
	}
}

