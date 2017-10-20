using EHR.DAL.Data;
using EHR.DAL.Entities.Base;
using EHR.DAL.Repositories;
using EHR.DAL.Storage.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Storage.Repositories
{
    public class StorageRepository<T> : Repository<T, StorageContext> where T : UniqueEntity
    {
        public StorageRepository(StorageContext context) : base(context)
        {
        }
    }
}
