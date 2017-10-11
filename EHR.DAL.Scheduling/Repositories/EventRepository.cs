using Microsoft.EntityFrameworkCore;
using EHR.DAL.Scheduling.Entities;
using EHR.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Scheduling.Data;

namespace EHR.DAL.Scheduling.Repositories
{
    public class EventRepository : SchedulingRepository<Event>
    {
        public EventRepository(SchedulingContext context) : base(context)
        {
        }
    }
}
