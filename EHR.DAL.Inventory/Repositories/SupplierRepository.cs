using EHR.DAL.Inventory.Entities;
using EHR.DAL.Inventory.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Inventory.Data;
using Microsoft.EntityFrameworkCore;
using EHR.DAL.Data;

namespace EHR.DAL.Inventory.Repositories
{
    public class SupplierRepository : InventoryRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(InventoryContext context) : base(context)
        {
        }
    }
}
