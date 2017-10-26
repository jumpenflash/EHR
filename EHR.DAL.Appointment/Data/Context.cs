using Microsoft.EntityFrameworkCore;
using EHR.DAL.Appointment.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;

namespace EHR.DAL.Appointment.Data
{
    public class AppointmentContext : BaseContext
    {
        public AppointmentContext(DbContextOptions<DbContext> options) : base(options)
        {
            AppointmentInitializer.Instance.Initialize(this);
        }

        public DbSet<Visit> Threads { get; set;}
        public DbSet<ThreadStatusType> ThreadStatusTypes { get; set; }
        public DbSet<ThreadStatusHistory> ThreadStatusHistories { get; set; }
        public DbSet<VisitGroup> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Visit>().ToTable("Thread");
            modelBuilder.Entity<ThreadStatusType>().ToTable("ThreadStatusType");
            modelBuilder.Entity<ThreadStatusHistory>().ToTable("ThreadStatusHistory");
            modelBuilder.Entity<VisitGroup>().ToTable("Post");
        }
    }
}
