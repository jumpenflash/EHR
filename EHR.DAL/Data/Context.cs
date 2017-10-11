using EHR.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Data
{
    public abstract class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<DbContext> options)
        {
            DbInitializer<BaseContext>.Instance.Initialize(this);
        }

        public DbSet<AuthToken> AuthTokens { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleMembership> RoleMemberships { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Module> Modules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthToken>().ToTable("AuthToken");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<RoleMembership>().ToTable("Memberships");
            modelBuilder.Entity<Permission>().ToTable("Permission");
            modelBuilder.Entity<Module>().ToTable("Module");
        }
    }
}
