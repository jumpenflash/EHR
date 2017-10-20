using Microsoft.EntityFrameworkCore;
using EHR.DAL.HelpDesk.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;

namespace EHR.DAL.HelpDesk.Data
{
    public class HelpDeskContext : BaseContext
    {
        public HelpDeskContext(DbContextOptions<DbContext> options) : base(options)
        {
            HelpDeskInitializer.Instance.Initialize(this);
        }

        public DbSet<Ticket> Tickets { get; set;}
        public DbSet<TicketNote> TicketNotes { get; set; }
        public DbSet<TicketStatusType> TicketStatusTypes { get; set; }
        public DbSet<TicketStatusHistory> TicketStatusHistories { get; set; }
        public DbSet<TicketGroup> TicketGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<TicketNote>().ToTable("TicketNote");
            modelBuilder.Entity<TicketStatusType>().ToTable("TicketStatusType");
            modelBuilder.Entity<TicketStatusHistory>().ToTable("TicketStatusHistory");
            modelBuilder.Entity<TicketGroup>().ToTable("TicketGroup");
        }
    }
}
