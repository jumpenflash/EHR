using EHR.DAL.Entities;
using EHR.DAL.Inventory.Entities;
using EHR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHR.DAL.Inventory.Repositories.Interfaces
{
    public interface IInventoryRepository<T> : IRepository<T> where T : UniqueEntity
    {
    }
}
