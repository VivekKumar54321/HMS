using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMS.Models;

namespace HMS.DatabaseConnection
{
	public class HMSContext : DbContext
	{
		public HMSContext(DbContextOptions<HMSContext> options)
			: base(options)
		{
		}

		public DbSet<HMS.Models.Visitor> Visitor { get; set; }
		public DbSet<HMS.Models.Room> Room { get; set; }
		public DbSet<HMS.Models.Reservation> Reservation { get; set; }
		public DbSet<HMS.Models.Billing> Billing { get; set; }
		public DbSet<HMS.Models.MiscellaneousBilling> MiscellaneousBilling { get; set; }
		public DbSet<HMS.Models.Login> Login { get; set; }



	}
}
