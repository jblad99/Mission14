using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mission14API.Data;

namespace Mission14API.Data
{
	public class MovieDbContext: DbContext
	{
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}

