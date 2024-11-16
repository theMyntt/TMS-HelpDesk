using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components;
using TMS.Application.Abstractions.User;
using TMS.Application.DTOs.User;

namespace TMS.Presentations.ViewModels.User
{
	public class LoginViewModel : INotifyPropertyChanged
	{
		private IUserLoginUseCase _useCase;
		private NavigationManager _navigation;

		private string _password = string.Empty;
		private string _email = string.Empty;

		[Required]
		[MinLength(7, ErrorMessage = "Password is invalid.")]
		public string Password
		{
			get => _password;
			set => SetProperty(ref _password, value);
		}

		[Required]
		[EmailAddress(ErrorMessage = "Email is invalid.")]
		public string Email
		{
			get => _email;
			set => SetProperty(ref _email, value);
		}

		public LoginViewModel(IUserLoginUseCase useCase, NavigationManager navigation)
		{
			_useCase = useCase;
			_navigation = navigation;
		}

        public event PropertyChangedEventHandler? PropertyChanged;

		public async Task<bool> Submit()
		{
			var result = await _useCase.Run(new UserLoginDTO.Input
			{
				Email = Email,
				Password = Password
			});

			if (result.IsT1)
				return false;

			_navigation.NavigateTo("/home");
			return true;
		}

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}

