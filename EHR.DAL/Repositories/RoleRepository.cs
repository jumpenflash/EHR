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
    public class RoleRepository : Repository<Role, BaseContext>, IRoleRepository
    {
        public RoleRepository(BaseContext Context)
            : base(Context)
        {
        }

        public void AddPermissionToRole(Permission permission, int roleId)
        {
            var role = Context.Roles.Where(r => r.Id == roleId).FirstOrDefault();

            if (role != null)
                role.Permissions.Add(permission);
        }

        public void AddUserToRole(User user, int roleId)
        {
            var role = Context.Roles.Where(r => r.Id == roleId).FirstOrDefault();

            if (role != null)
            {
                RoleMembership m = new RoleMembership();
                m.User = user;
                m.Role = role;

                Context.RoleMemberships.Add(m);
            }
        }

        public IEnumerable<Role> GetAllByUserId(int userId)
        {
            var results = from m in Context.RoleMemberships
                          where m.User.Id == userId
                          select m.Role;

            return results.ToList();
        }
    }
}
