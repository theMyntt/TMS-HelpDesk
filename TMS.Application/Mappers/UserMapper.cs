using System;
using TMS.Application.Abstractions.User;
using TMS.Domain.Aggregates;
using TMS.Infra.Data.Entities;

namespace TMS.Application.Mappers
{
    public class UserMapper : IUserMapper
	{
		public UserMapper()
		{
		}

        public UserAggregate ToDomain(UserEntity entity)
        {
            return new UserAggregate
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Password = entity.Password,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }

        public UserEntity ToPersistance(UserAggregate aggregate)
        {
            return new UserEntity
            {
                Id = aggregate.Id,
                Name = aggregate.Name,
                Email = aggregate.Email,
                Password = aggregate.Password,
                CreatedAt = aggregate.CreatedAt,
                UpdatedAt = aggregate.UpdatedAt
            };
        }
    }
}

