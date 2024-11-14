using System;
using Microsoft.Extensions.DependencyInjection;

namespace TMS.Infra.Ioc
{
	public static class Dependencies
	{
		public static IServiceCollection AddExtensions(this IServiceCollection services) 
		{
			return services;
		}
	}
}

