using EHR.DAL.Admin.Entities;
using EHR.DAL.Data;
using System;
using System.Linq;

namespace EHR.DAL.Admin.Data
{
    public class AdminIntializer : DbInitializer<AdminContext>
    {
        public override void Initialize(AdminContext context)
        {
            base.Initialize(context);

            // Look for any Menus.
            if (context.Menus.Any())
            {
                return;   // DB has been seeded
            }

            var Menus = new Menu[]
            {
            new Menu{ Name ="Home", Url = "/"}
            };
            foreach (Menu s in Menus)
            {
                context.Menus.Add(s);
            }
            context.SaveChanges();
        }
    }
}