using Microsoft.EntityFrameworkCore;
using EHR.DAL.Log.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;

namespace EHR.DAL.Log.Contexts
{
    public class LogDataContext : BaseContext
    {
        public LogDataContext(DbContextOptions<DbContext> options) : base(options)
        {
            DbInitializer.Initialize(this);
        }

        public DbSet<Event> Events { get; set; }
    }
}
