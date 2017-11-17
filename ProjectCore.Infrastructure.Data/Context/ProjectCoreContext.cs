﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectCore.Infrastructure.Data.Context.Mapping;

namespace ProjectCore.Infrastructure.Data.Context
{
    public class ProjectCoreContext : DbContext
    {
        public ProjectCoreContext(DbContextOptions<ProjectCoreContext> options) : base(options)
        {                    
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.AddConfiguration(new UserMap());
            modelBuilder.AddConfiguration(new RoleMap());
            modelBuilder.AddConfiguration(new PrivilegeMap());
            modelBuilder.AddConfiguration(new ResourceMap());
            modelBuilder.AddConfiguration(new ModuleMap());
            
        }
    }

    internal static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(
            this ModelBuilder modelBuilder,
            DbEntityConfiguration<TEntity> entityConfiguration) where TEntity : class
        {
            modelBuilder.Entity<TEntity>(entityConfiguration.Configure);
        }
    }

    internal abstract class DbEntityConfiguration<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> entity);
    }
}
