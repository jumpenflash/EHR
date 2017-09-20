using System;
using System.Collections.Generic;
using System.Text;
using EHR.DAL.Entities;
using EHR.BLL.UnitOfWork.Interfaces;
using EHR.DAL.Inventory.Data;
using EHR.DAL.Inventory.Repositories;
using EHR.DAL.Inventory.Repositories.Interfaces;
using EHR.BLL.Inventory.UnitOfWork.Interfaces;

namespace EHR.BLL.Inventory.UnitOfWork
{
    public class InventoryUnitOfWork : IInventoryUnitOfWork
    {
        private readonly InventoryContext _context;

        public InventoryUnitOfWork(InventoryContext context, ISupplierRepository suppliers)
        {
            _context = context;

            Suppliers = suppliers;
        }

        public ISupplierRepository Suppliers { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
