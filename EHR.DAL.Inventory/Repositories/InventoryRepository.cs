using EHR.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Linq;
using EHR.DAL.Repositories.Interfaces;
using EHR.DAL.Repositories;
using EHR.DAL.Inventory.Entities;
using EHR.DAL.Inventory.Repositories.Interfaces;
using EHR.DAL.Inventory.Data;

namespace EHR.DAL.Inventory.Repositories
{
    public class InventoryRepository<T> : Repository<T>, IInventoryRepository<T> where T : UniqueEntity
    {
        public InventoryRepository(InventoryContext Context)
            : base(Context)
        {
        }

        public InventoryContext InventoryContext
        {
            get { return Context as InventoryContext; }
            set { Context = value; }
        }
    }
}
