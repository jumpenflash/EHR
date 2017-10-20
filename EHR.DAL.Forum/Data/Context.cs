using Microsoft.EntityFrameworkCore;
using EHR.DAL.Forum.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;

namespace EHR.DAL.Forum.Data
{
    public class ForumContext : BaseContext
    {
        public ForumContext(DbContextOptions<DbContext> options) : base(options)
        {
            ForumInitializer.Instance.Initialize(this);
        }

        public DbSet<Thread> Threads { get; set;}
        public DbSet<ThreadStatusType> ThreadStatusTypes { get; set; }
        public DbSet<ThreadStatusHistory> ThreadStatusHistories { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Thread>().ToTable("Thread");
            modelBuilder.Entity<ThreadStatusType>().ToTable("ThreadStatusType");
            modelBuilder.Entity<ThreadStatusHistory>().ToTable("ThreadStatusHistory");
            modelBuilder.Entity<Post>().ToTable("Post");
        }
    }
}
