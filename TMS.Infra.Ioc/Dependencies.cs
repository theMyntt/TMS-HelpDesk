using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TMS.Infra.Data.Abstractions;
using TMS.Infra.Data.Context;
using TMS.Infra.Data.Repositories;

namespace TMS.Infra.Ioc
{
	public static class Dependencies
	{
		public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration) 
		{
			var conn = configuration.GetConnectionString("MSSQL") ?? throw new Exception("MSSQL CONN IS NULL");

			services.AddDbContext<DatabaseContext>(
				options => options.UseSqlServer(conn,
					m => m.MigrationsAssembly(typeof(DatabaseContext).Assembly.FullName)));

			return services;
		}

		public static IServiceCollection AddInfraLayer(this IServiceCollection services)
		{
			services.AddScoped<IUserRepository, UserRepository>();

			return services;
		}
	}
}

