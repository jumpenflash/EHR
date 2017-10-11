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
    public class PermissionRepository : Repository<Permission, BaseContext>, IPermissionRepository
    {
        public PermissionRepository(BaseContext Context)
            : base(Context)
        {
        }

        public IEnumerable<Permission> GetAllByRoleId(int roleId)
        {
            var results = from p in Context.Permissions
                          where p.Role.Id == roleId
                          select p;

            return results.ToList();
        }
    }
}
