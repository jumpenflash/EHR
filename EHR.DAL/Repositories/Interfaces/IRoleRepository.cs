﻿using EHR.DAL.Entities;
using EHR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHR.DAL.Repositories.Interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        IEnumerable<Role> GetAllByUserId(int userId);

        void AddUserToRole(User user, int roleId);
        void AddPermissionToRole(Permission permission, int roleId);
    }
}
