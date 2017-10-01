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
    public class RoleRepository : AdminRepository<Role>, IRoleRepository
    {
        public RoleRepository(AdminContext Context)
            : base(Context)
        {
        }

        public void AddPermissionToRole(Permission permission, int roleId)
        {
            var role = AdminContext.Roles.Where(r => r.Id == roleId).FirstOrDefault();

            if (role != null)
                role.Permissions.Add(permission);
        }

        public void AddUserToRole(User user, int roleId)
        {
            var role = AdminContext.Roles.Where(r => r.Id == roleId).FirstOrDefault();

            if (role != null)
            {
                Membership m = new Membership();
                m.User = user;
                m.Role = role;

                AdminContext.Memberships.Add(m);
            }
        }

        public IEnumerable<Role> GetAllByUserId(int userId)
        {
            var results = from m in AdminContext.Memberships
                          where m.User.Id == userId
                          select m.Role;

            return results.ToList();
        }
    }
}
