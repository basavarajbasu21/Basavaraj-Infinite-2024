using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Models
{
    public class MoviesContext : DbContext
    {
        // GET: Movies
        public class MoviesDbContext : DbContext
        {
            public DbSet<Movie> Movies { get; set; }
        }

    }
}