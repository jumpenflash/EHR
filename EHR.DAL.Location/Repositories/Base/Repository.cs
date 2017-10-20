using EHR.DAL.Location.Data;
using EHR.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Entities.Base;

namespace EHR.DAL.Location.Repositories
{
    public class LocationRepository<T> : Repository<T, LocationContext> where T : UniqueEntity
    {
        public LocationRepository(LocationContext context) : base(context)
        {
        }
    }
}
