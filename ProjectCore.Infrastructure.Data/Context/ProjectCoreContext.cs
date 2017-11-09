using Microsoft.EntityFrameworkCore;
using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.Infrastructure.Data.Context
{
    public class ProjectCoreContext : DbContext
    {
        public ProjectCoreContext(DbContextOptions<ProjectCoreContext> options) : base(options)
        {                    
        }

        public DbSet<User> User { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Privilege> Privilege { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity(typeof(User)).HasOne(typeof(Role)).WithMany().OnDelete(DeleteBehavior.Restrict);    
        }
    }
}
