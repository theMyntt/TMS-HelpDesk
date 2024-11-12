using System;
using Microsoft.EntityFrameworkCore;
using TMS.Infra.Data.Entities;

namespace TMS.Infra.Data.Context
{
	public class DatabaseContext : DbContext
	{
		public DbSet<UserEntity> Users { get; set; }

		public DatabaseContext(DbContextOptions options) : base(options)
		{
		}
	}
}

