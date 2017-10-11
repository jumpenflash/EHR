using Microsoft.EntityFrameworkCore;
using EHR.DAL.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;

namespace EHR.DAL.Storage.Data
{
    public class StorageContext : BaseContext
    {
        public StorageContext(DbContextOptions<DbContext> options) : base(options)
        {
            StorageInitializer.Instance.Initialize(this);
        }

        public DbSet<File> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<File>().ToTable("File");
        }
    }
}
