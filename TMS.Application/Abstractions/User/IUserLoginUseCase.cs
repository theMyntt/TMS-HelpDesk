using System;
using OneOf;
using TMS.Application.DTOs.User;
using TMS.Domain.Core;

namespace TMS.Application.Abstractions.User
{
	public interface IUserLoginUseCase : IUseCase<UserLoginDTO.Input, OneOf<UserLoginDTO.Output, StandardResponse>>
	{
	}
}

