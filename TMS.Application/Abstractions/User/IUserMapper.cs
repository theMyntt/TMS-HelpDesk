using System;
using TMS.Domain.Aggregates;
using TMS.Domain.Core;
using TMS.Infra.Data.Entities;

namespace TMS.Application.Abstractions.User
{
    public interface IUserMapper : IMapper<UserAggregate, UserEntity>
    {
	}
}

