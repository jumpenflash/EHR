using EHR.DAL.Admin.Data;
using EHR.DAL.Admin.Repositories.Interfaces;
using EHR.DAL.Entities;
using EHR.DAL.Repositories;
using EHR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EHR.DAL.Entities.Base;
using EHR.DAL.Data;

namespace EHR.DAL.Admin.Repositories
{
    public class AdminRepository<T> : Repository<T, AdminContext>, IAdminRepository<T> where T : UniqueEntity
    {
        public AdminRepository(AdminContext context) : base(context)
        {
        }
    }
}
