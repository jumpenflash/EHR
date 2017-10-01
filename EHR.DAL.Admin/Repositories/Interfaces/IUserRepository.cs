using EHR.DAL.Entities;
using EHR.DAL.Admin.Entities;
using EHR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHR.DAL.Admin.Repositories.Interfaces
{
    public interface IUserRepository : IAdminRepository<User>
    {
        IEnumerable<User> GetAllByRoleId(int roleId);

        void AddRoleToUser(Role role, int userId);
    }
}
