using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TMS.Infra.Data.Abstractions;
using TMS.Infra.Data.Context;
using TMS.Infra.Data.Entities;
using TMS.Infra.Data.Exceptions;

namespace TMS.Infra.Data.Repositories
{
	public class UserRepository : IUserRepository
	{
        private readonly DatabaseContext _context;

        public UserRepository(DatabaseContext context) => _context = context;

        public async Task CreateUser(UserEntity entity)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == entity.Email);

            if (user != null)
            {
                throw new UserAlreadyExistsException();
            }

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteUser(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task EditUser(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> Filter(Expression<Func<UserEntity, bool>> filter, int page)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetUsers(int page)
        {
            throw new NotImplementedException();
        }
    }
}

