using System;
using TMS.Application.Abstractions.User;
using TMS.Presentations.ViewModels.User;

namespace TMS.Presentations.Pages.User
{
	public partial class Login
	{
		private readonly LoginViewModel _viewModel;

		public Login(LoginViewModel viewModel)
		{
			_viewModel = viewModel; 
		}

		private void Submit()
		{

		}
	}
}

