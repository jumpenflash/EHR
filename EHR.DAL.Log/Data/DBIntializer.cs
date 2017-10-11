using EHR.DAL.Data;
using EHR.DAL.Log.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Log.Data
{
    public class LogInitializer : DbInitializer<LogContext>
    {
        public override void Initialize(LogContext context)
        {
            base.Initialize(context);
        }
    }
}