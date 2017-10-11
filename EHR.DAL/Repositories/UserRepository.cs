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
    public class UserRepository : Repository<User, BaseContext>, IUserRepository
    {
        public UserRepository(BaseContext Context)
            : base(Context)
        {
        }

        public void AddRoleToUser(Role role, int userId)
        {
            var user = Context.Users.Where(u => u.Id == userId).FirstOrDefault();

            if (user != null)
            {
                RoleMembership m = new RoleMembership();
                m.User = user;
                m.Role = role;

                Context.RoleMemberships.Add(m);
            }
        }

        public IEnumerable<User> GetAllByRoleId(int roleId)
        {
            var results = from m in Context.RoleMemberships
                          where m.Role.Id == roleId
                          select m.User;

            return results.ToList();
        }
    }
}
