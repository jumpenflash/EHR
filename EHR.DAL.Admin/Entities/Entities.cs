using EHR.DAL.Entities;
using EHR.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Admin.Entities
{
    public class EmergancyContact : ManagedEntity
    {
        public User Contact { get; set; }
        public EmergancyContactType Type { get; set; }
    }

    public class EmergancyContactType : TypeEntity
    {
    }

    public class Menu : ManagedEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public MenuType MenuType { get; set; }
        public Module Module { get; set; }
        public Menu ParentMenu { get; set; }

        public ICollection<Menu> ChildMenus { get; set; }
    }

    public class MenuType : TypeEntity
    {
        public ICollection<Menu> Events { get; set; }
    }
}
