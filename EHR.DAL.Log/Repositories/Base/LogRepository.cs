using EHR.DAL.Log.Contexts;
using EHR.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Entities.Base;

namespace EHR.DAL.Log.Repositories
{
    public class LogRepository<T> : Repository<T> where T : UniqueEntity
    {
        public LogRepository(BaseContext context) : base(context)
        {
        }

        public LogDataContext LogContext
        {
            get { return Context as LogDataContext; }
            set { Context = value; }
        }
    }
}
