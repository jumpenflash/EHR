using EHR.DAL.Inventory.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Inventory.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
            DbInitializer.Initialize(this);
        }

        public DbSet<Formula> Formulas { get; set; }
        public DbSet<Herb> Herbs { get; set; }
        public DbSet<Stationary> Stationaries { get; set; }
        public DbSet<Needle> Needles { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formula>().ToTable("Formula");
            modelBuilder.Entity<Herb>().ToTable("Herb");
            modelBuilder.Entity<Stationary>().ToTable("Stationary");
            modelBuilder.Entity<Needle>().ToTable("Needle");
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
        }
    }
}
