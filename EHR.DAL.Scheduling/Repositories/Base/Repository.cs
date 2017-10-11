using EHR.DAL.Scheduling.Data;
using EHR.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Entities.Base;

namespace EHR.DAL.Scheduling.Repositories
{
    public class SchedulingRepository<T> : Repository<T, SchedulingContext> where T : UniqueEntity
    {
        public SchedulingRepository(SchedulingContext context) : base(context)
        {
        }
    }
}
