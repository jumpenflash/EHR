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
    public class PermissionRepository : AdminRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(AdminContext Context)
            : base(Context)
        {
        }

        public IEnumerable<Permission> GetAllByRoleId(int roleId)
        {
            var results = from p in AdminContext.Permissions
                          where p.Role.Id == roleId
                          select p;

            return results.ToList();
        }
    }
}
