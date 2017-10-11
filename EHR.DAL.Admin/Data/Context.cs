using EHR.DAL.Admin.Entities;
using EHR.DAL.Data;
using EHR.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Admin.Data
{
    public class AdminContext : BaseContext
    {
        public AdminContext(DbContextOptions<DbContext> options) : base(options)
        {
            AdminIntializer.Instance.Initialize(this);
        }

        public DbSet<EmergancyContact> EmergancyContacts { get; set; }
        public DbSet<EmergancyContactType> EmergancyContactTypes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EmergancyContact>().ToTable("EmergancyContact");
            modelBuilder.Entity<EmergancyContactType>().ToTable("EmergancyContactType");
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<MenuType>().ToTable("MenuType");
        }
    }
}
