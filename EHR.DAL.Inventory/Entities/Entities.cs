using EHR.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Inventory.Entities
{
    public class InventoryItem : EditableEntity
    {
        public string SKU { get; set; }
        public decimal PricePerUnit { get; set; }
        public int Count { get; set; }

        public ICollection<Supplier> Suppliers { get; set; }
        //public ICollection<InventoryItemAttribute> Attributes { get; set; }
    }

    //public class InventoryItemAttribute : XRefEntity
    //{
    //    public InventoryItemAttributeType Type { get; set; }
    //    public InventoryItemAttributeGroup Group { get; set; }
    //}

    //public class InventoryItemAttributeType : TypeEntity
    //{

    //}

    //public class InventoryItemAttributeGroup : TypeEntity
    //{

    //}

    public class Formula : InventoryItem
    {
    }
    public class Herb : InventoryItem
    {

    }
    public class Stationary : InventoryItem
    {

    }
    public class Needle : InventoryItem
    {

    }

    public class Supplier : EditableEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string WebSite { get; set; }

        public ICollection<SupplierAddress> Addresses { get; set; }
    }

    public class SupplierAddress : EditableEntity
    {
        public Address Address { get; set; }
        public SupplierAddressType SupplierAddressType { get; set; }
    }

    public class SupplierAddressType : TypeEntity
    {
    }
}
