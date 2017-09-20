using EHR.DAL.Entities;
using EHR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.BLL.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
