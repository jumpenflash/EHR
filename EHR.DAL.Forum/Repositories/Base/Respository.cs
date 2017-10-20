using EHR.DAL.Data;
using EHR.DAL.Entities.Base;
using EHR.DAL.Repositories;
using EHR.DAL.Forum.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Forum.Repositories
{
    public class ForumRepository<T> : Repository<T, ForumContext> where T : UniqueEntity
    {
        public ForumRepository(ForumContext context) : base(context)
        {
        }
    }
}
