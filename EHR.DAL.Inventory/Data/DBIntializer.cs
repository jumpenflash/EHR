using EHR.DAL.Inventory.Entities;
using System;
using System.Linq;

namespace EHR.DAL.Inventory.Data
{
    public static class DbInitializer
    {
        public static void Initialize(InventoryContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Suppliers.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Supplier[]
            {
            new Supplier{Name="Suppler one",WebSite="https://www.google.com"},
            new Supplier{Name="Suppler two",WebSite="https://www.google.com"},
            new Supplier{Name="Suppler three",WebSite="https://www.google.com"},
            new Supplier{Name="Suppler four",WebSite="https://www.google.com"},
            new Supplier{Name="Suppler five",WebSite="https://www.google.com"},
            new Supplier{Name="Suppler six",WebSite="https://www.google.com"},
            new Supplier{Name="Suppler seven",WebSite="https://www.google.com"},
            new Supplier{Name="Suppler eight",WebSite="https://www.google.com"}
            };
            foreach (Supplier s in students)
            {
                context.Suppliers.Add(s);
            }
            context.SaveChanges();
        }
    }
}