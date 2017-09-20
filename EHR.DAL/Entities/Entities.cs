using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EHR.DAL.Entities
{
    public abstract class UniqueEntity
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }
    }

    public abstract class ReadOnlyEntity : UniqueEntity
    {
        [Column(Order = 100)]
        public int CreatedByUserId { get; set; }
        [Column(Order = 101)]
        public DateTime CreatedDate { get; set; }
    }

    public abstract class EditableEntity : ReadOnlyEntity
    {
        [Column(Order = 102)]
        public int LastModifiedByUserId { get; set; }
        [Column(Order = 103)]
        public DateTime LastModifiedDate { get; set; }
    }

    public abstract class HistoricalEntity : ReadOnlyEntity
    {
        [Column(Order = 99)]
        public bool MostRecent { get; set; }
    }

    public abstract class TypeEntity : UniqueEntity
    {
        [Column(Order = 2)]
        public string Name { get; set; }
        [Column(Order = 3)]
        public int SortOrder { get; set; }
        [Column(Order = 4)]
        public bool Active { get; set; }
    }

    public class Address : EditableEntity
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
}
