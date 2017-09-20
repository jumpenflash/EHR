using EHR.BLL.UnitOfWork.Interfaces;
using EHR.DAL.Inventory.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.BLL.Inventory.UnitOfWork.Interfaces
{
    public interface IInventoryUnitOfWork : IUnitOfWork
    {
        ISupplierRepository Suppliers { get; }
    }
}
