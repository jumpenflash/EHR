using EHR.DAL.Data;
using EHR.DAL.Storage.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Storage.Data
{
    public class StorageInitializer : DbInitializer<StorageContext>
    {
        public override void Initialize(StorageContext context)
        {
            base.Initialize(context);
        }
    }
}