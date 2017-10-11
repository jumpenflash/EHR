using EHR.DAL.Data;
using EHR.DAL.Scheduling.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Scheduling.Data
{
    public class SchedulingInitializer : DbInitializer<SchedulingContext>
    {
        public override void Initialize(SchedulingContext context)
        {
            base.Initialize(context);
        }
    }
}