﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
	public class TestContext : DbContext
	{
		
			public TestContext(DbContextOptions<TestContext> options)
				: base(options)
			{
			}
		//public DbSet<LEMS.User> User { get; set; }

	}
}

