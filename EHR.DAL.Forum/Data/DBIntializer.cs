using EHR.DAL.Data;
using EHR.DAL.Forum.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Forum.Data
{
    public class ForumInitializer : DbInitializer<ForumContext>
    {
        public override void Initialize(ForumContext context)
        {
            base.Initialize(context);
        }
    }
}