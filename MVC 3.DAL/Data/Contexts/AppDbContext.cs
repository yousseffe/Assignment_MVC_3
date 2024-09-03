using Microsoft.EntityFrameworkCore;
using MVC_3.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_3.DAL.Data.Contexts
{
	internal class AppDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = . ; Database = MVC3 ; Trusted_Connection = True ; MultipleActiveResultSets = True");

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
		}

		public DbSet<Department> Departments { get; set; }

	}
}
