using Microsoft.EntityFrameworkCore;
using EHR.DAL.Log.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;

namespace EHR.DAL.Log.Data
{
    public class LogContext : BaseContext
    {
        public LogContext(DbContextOptions<DbContext> options) : base(options)
        {
            LogInitializer.Instance.Initialize(this);
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventAttribute> EventAttributes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<EventType>().ToTable("EventType");
            modelBuilder.Entity<EventAttribute>().ToTable("EventAttribute");
        }
    }
}
