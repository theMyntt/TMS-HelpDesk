
using System;
using System.Linq.Expressions;
using TMS.Infra.Data.Entities;

namespace TMS.Infra.Data.Abstractions
{
	public interface IUserRepository
	{
		Task CreateUser(UserEntity entity);
		Task EditUser(UserEntity entity);
		Task<IEnumerable<UserEntity>> GetUsers(int page);
		Task<IEnumerable<UserEntity>> Filter(Expression<Func<UserEntity, bool>> filter, int page);
		Task DeleteUser(UserEntity entity);
	}
}

