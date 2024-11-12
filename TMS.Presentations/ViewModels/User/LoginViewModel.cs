using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TMS.Presentations.ViewModels.User
{
	public class LoginViewModel : INotifyPropertyChanged
	{
		private string _password;
		private string _email;

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

		public LoginViewModel()
		{
		}

        public event PropertyChangedEventHandler? PropertyChanged;

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

