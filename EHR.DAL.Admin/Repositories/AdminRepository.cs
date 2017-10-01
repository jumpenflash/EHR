using EHR.DAL.Admin.Data;
using EHR.DAL.Admin.Repositories.Interfaces;
using EHR.DAL.Entities;
using EHR.DAL.Repositories;
using EHR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EHR.DAL.Admin.Repositories
{
    public class AdminRepository<T> : Repository<T>, IAdminRepository<T> where T : UniqueEntity
    {
        public AdminRepository(DbContext context) : base(context)
        {
        }

        public AdminContext AdminContext
        {
            get { return Context as AdminContext; }
            set { Context = value; }
        }
    }
}
