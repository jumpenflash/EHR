using EHR.DAL.Log.Data;
using EHR.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Entities.Base;

namespace EHR.DAL.Log.Repositories
{
    public class LogRepository<T> : Repository<T, LogContext> where T : UniqueEntity
    {
        public LogRepository(LogContext context) : base(context)
        {
        }
    }
}
