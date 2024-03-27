using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext (DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }
        public DbSet<lesson> Lessons { get; set; }

        public DbSet<userdata> userdata { get; set; }

        public DbSet<mentor> Mentor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mentor>().ToTable("Mentor");
            modelBuilder.Entity<userdata>().ToTable("userdata");
            modelBuilder.Entity<lesson>().ToTable("lesson");
        }
    }
}
