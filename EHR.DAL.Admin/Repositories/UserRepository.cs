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
    public class UserRepository : AdminRepository<User>, IUserRepository
    {
        public UserRepository(AdminContext Context)
            : base(Context)
        {
        }

        public void AddRoleToUser(Role role, int userId)
        {
            var user = AdminContext.Users.Where(u => u.Id == userId).FirstOrDefault();

            if (user != null)
            {
                Membership m = new Membership();
                m.User = user;
                m.Role = role;

                AdminContext.Memberships.Add(m);
            }
        }

        public IEnumerable<User> GetAllByRoleId(int roleId)
        {
            var results = from m in AdminContext.Memberships
                          where m.Role.Id == roleId
                          select m.User;

            return results.ToList();
        }
    }
}
