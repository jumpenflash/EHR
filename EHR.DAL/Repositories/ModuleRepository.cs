using EHR.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Linq;
using EHR.DAL.Repositories.Interfaces;
using EHR.DAL.Repositories;
using EHR.DAL.Data;

namespace EHR.DAL.Repositories
{
    public class ModuleRepository : Repository<Module, BaseContext>, IModuleRepository
    {
        public ModuleRepository(BaseContext Context)
            : base(Context)
        {
        }
    }
}
