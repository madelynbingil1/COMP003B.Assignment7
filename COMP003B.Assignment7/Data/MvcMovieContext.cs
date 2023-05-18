using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP003B.Assignment7.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<COMP003B.Assignment7.Models.Actor> Actor { get; set; }

        public DbSet<COMP003B.Assignment7.Models.Movie> Movie { get; set; }

        public DbSet<COMP003B.Assignment7.Models.MovieActor> MovieActor { get; set; }
    }
