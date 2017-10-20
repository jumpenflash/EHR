using EHR.DAL.Data;
using EHR.DAL.Location.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Location.Data
{
    public class LocationInitializer : DbInitializer<LocationContext>
    {
        public override void Initialize(LocationContext context)
        {
            base.Initialize(context);
        }
    }
}