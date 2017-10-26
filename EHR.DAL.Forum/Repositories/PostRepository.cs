using EHR.DAL.Forum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EHR.DAL.Data;
using EHR.DAL.Forum.Data;

namespace EHR.DAL.Forum.Repositories
{
    public class PostRepository : ForumRepository<Post>
    {
        public PostRepository(ForumContext context) : base(context)
        {
        }

        public IEnumerable<Post> GetAllByAssignedToUserId(int assignedToUserId)
        {
            var results = from ti in Context.Posts
                          where ti.AssignedToUser.Id == assignedToUserId
                          select ti;

            return results;
        }
        public IEnumerable<Post> GetAllByPostGroupId(int PostGroupId)
        {
            var results = from ti in Context.Posts
                          where ti.PostGroup.Id == PostGroupId
                          select ti;

            return results;
        }
    }
}
