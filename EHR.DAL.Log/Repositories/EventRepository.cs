﻿using Microsoft.EntityFrameworkCore;
using EHR.DAL.Log.Entities;
using EHR.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Log.Data;

namespace EHR.DAL.Log.Repositories
{
    public class EventRepository : LogRepository<Event>
    {
        public EventRepository(LogContext context) : base(context)
        {
        }

        public IEnumerable<Event> GetAllByKeyword(string keyword)
        {
            var results = from e in Context.Events
                          where e.Message.Contains(keyword) || 
                                e.EventAttributes.Select(ea => ea.Value).Contains(keyword)
                          select e;

            return results.Include(e => e.EventAttributes);
        }
    }
}
