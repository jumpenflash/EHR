using Microsoft.EntityFrameworkCore;
using EHR.DAL.Task.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;

namespace EHR.DAL.Task.Data
{
    public class TaskContext : BaseContext
    {
        public TaskContext(DbContextOptions<DbContext> options) : base(options)
        {
            TaskInitializer.Instance.Initialize(this);
        }

        public DbSet<TaskItem> TaskItems { get; set;}
        public DbSet<TaskItemNote> TaskItemNotes { get; set; }
        public DbSet<TaskItemGroup> TaskItemGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskItem>().ToTable("TaskItem");
            modelBuilder.Entity<TaskItemNote>().ToTable("TaskItemNote");
            modelBuilder.Entity<TaskItemGroup>().ToTable("TaskItemGroup");
        }
    }
}
