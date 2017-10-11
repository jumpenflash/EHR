using EHR.DAL.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Storage.Data;

namespace EHR.DAL.Storage.Repositories
{
    public class FileRepository : StorageRepository<File>
    {
        public FileRepository(StorageContext context) : base(context)
        {
        }
    }
}
