using EHR.DAL.Entities;
using EHR.DAL.Admin.Entities;
using EHR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHR.DAL.Admin.Repositories.Interfaces
{
    public interface IPermissionRepository : IAdminRepository<Permission>
    {
        IEnumerable<Permission> GetAllByRoleId(int roleId);
    }
}
