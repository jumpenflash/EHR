using EHR.DAL.Admin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Admin.Data
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options) : base(options)
        {
            DbInitializer.Initialize(this);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<EmergancyContact> EmergancyContacts { get; set; }
        public DbSet<EmergancyContactType> EmergancyContactTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Module> Modules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<EmergancyContact>().ToTable("EmergancyContact");
            modelBuilder.Entity<EmergancyContactType>().ToTable("EmergancyContactType");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<Membership>().ToTable("Memberships");
            modelBuilder.Entity<Permission>().ToTable("Permission");
            modelBuilder.Entity<Module>().ToTable("Module");
        }
    }
}
