using EHR.DAL.Entities;
using EHR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Admin.Repositories.Interfaces
{
    public interface IAdminRepository<T> : IRepository<T> where T : UniqueEntity
    {
    }
}
