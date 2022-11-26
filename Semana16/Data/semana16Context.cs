using Microsoft.EntityFrameworkCore;
using Semana16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana16.Data
{
    public class semana16Context : DbContext
    {

        public semana16Context(DbContextOptions<semana16Context> options) : base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Teather> Teather { get; set; }
    }
}
