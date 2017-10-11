using Microsoft.EntityFrameworkCore;
using EHR.DAL.Scheduling.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;

namespace EHR.DAL.Scheduling.Data
{
    public class SchedulingContext : BaseContext
    {
        public SchedulingContext(DbContextOptions<DbContext> options) : base(options)
        {
            SchedulingInitializer.Instance.Initialize(this);
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<AttendeeStatusHistory> AttendeeStatusHistories { get; set; }
        public DbSet<AttendeeStatusType> AttendeeStatusTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<EventType>().ToTable("EventType");
            modelBuilder.Entity<Attendee>().ToTable("Attendee");
            modelBuilder.Entity<AttendeeStatusHistory>().ToTable("AttendeeStatusHistory");
            modelBuilder.Entity<AttendeeStatusType>().ToTable("AttendeeStatusType");
        }
    }
}
