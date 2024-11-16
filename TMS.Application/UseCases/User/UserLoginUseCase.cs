using System;
using OneOf;
using TMS.Application.Abstractions.User;
using TMS.Application.DTOs.User;
using TMS.Domain.Core;
using TMS.Infra.Data.Abstractions;

namespace TMS.Application.UseCases.User
{
	public class UserLoginUseCase : IUserLoginUseCase
	{
        private readonly IUserRepository _repository;
        private readonly IUserMapper _mapper;

		public UserLoginUseCase(IUserRepository repository, IUserMapper mapper)
		{
            _repository = repository;
            _mapper = mapper;
		}

        public async Task<OneOf<UserLoginDTO.Output, StandardResponse>> Run(UserLoginDTO.Input input)
        {
            var users = await _repository.Filter(m => m.Email == input.Email && m.Password == input.Password, 1);

            if (users == null || !users.Any())
            {
                return new StandardResponse
                {
                    Message = "User not found",
                    StatusCode = 404,
                    Code = "UserNotFoundException"
                };
            }

            var user = _mapper.ToDomain(users.First());

            return new UserLoginDTO.Output
            {
                Message = "User found",
                StatusCode = 200,
                User = user,
                Code = "UserFound"
            };
        }
    }
}

