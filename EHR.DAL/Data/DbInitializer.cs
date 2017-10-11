using EHR.DAL.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Data
{
    public class DbInitializer<T> where T : BaseContext
    {
        protected static DbInitializer<T> instance;

        protected DbInitializer() { }

        public static DbInitializer<T> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbInitializer<T>();
                }
                return instance;
            }
        }

        public virtual void Initialize(T context)
        {
            context.Database.EnsureCreated();

            // Look for any Users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{ FirstName ="System", LastName = "Administrator", UserName="sysadmin"}
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

            var Roles = new Role[]
            {
                new Role{ Name ="System Administrators" }
            };
            foreach (Role s in Roles)
            {
                context.Roles.Add(s);
            }
            context.SaveChanges();
        }
    }
}