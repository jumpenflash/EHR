using EHR.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Linq;
using EHR.DAL.Repositories.Interfaces;
using EHR.DAL.Repositories;
using EHR.DAL.Admin.Entities;
using EHR.DAL.Admin.Repositories.Interfaces;
using EHR.DAL.Admin.Data;

namespace EHR.DAL.Admin.Repositories
{
    public class ModuleRepository : AdminRepository<Module>, IModuleRepository
    {
        public ModuleRepository(AdminContext Context)
            : base(Context)
        {
        }
    }
}
