using EHR.DAL.Admin.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Admin.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AdminContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{ FirstName ="System", LastName = "Administratir", UserName="sysadmin", EmailAddress="sysadmin@email.com"}
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();
        }
    }
}