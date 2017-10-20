using Microsoft.EntityFrameworkCore;
using EHR.DAL.Location.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;

namespace EHR.DAL.Location.Data
{
    public class LocationContext : BaseContext
    {
        public LocationContext(DbContextOptions<DbContext> options) : base(options)
        {
            LocationInitializer.Instance.Initialize(this);
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
