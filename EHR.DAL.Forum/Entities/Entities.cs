using EHR.DAL.Entities;
using EHR.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Forum.Entities
{
    public class Thread: ManagedEntity
    {
        public string Title { get; set; }

        public User AuthorUser { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

    public class Post : ManagedEntity
    {
        public string Body { get; set; }

        public User AuthorUser { get; set; }
        public Post ParentPost { get; set; }

        public ICollection<Post> SubPosts { get; set; }
    }

    public class ThreadStatusType : TypeEntity
    {
    }

    public class ThreadStatusHistory : HistoricalEntity
    {
        public Thread Thread { get; set; }
        public ThreadStatusType ThreadStatusType { get; set; }
    }

    public class ThreadCategory : UnmanagedEntity
    {
        public Thread Thread { get; set; }
        public ThreadCategoryType ThreadCategoryType { get; set; }
    }

    public class ThreadCategoryType : TypeEntity
    {

    }
}
