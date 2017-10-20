using EHR.DAL.Data;
using EHR.DAL.Entities.Base;
using EHR.DAL.Repositories;
using EHR.DAL.HelpDesk.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.HelpDesk.Repositories
{
    public class HelpDeskRepository<T> : Repository<T, HelpDeskContext> where T : UniqueEntity
    {
        public HelpDeskRepository(HelpDeskContext context) : base(context)
        {
        }
    }
}
