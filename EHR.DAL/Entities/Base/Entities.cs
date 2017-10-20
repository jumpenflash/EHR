using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EHR.DAL.Entities.Base
{
    public abstract class UniqueEntity
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }
    }

    public abstract class UnmanagedEntity : UniqueEntity
    {
        [Column(Order = 101)]
        public DateTime CreatedDate { get; set; }

        public User CreatedByUser { get; set; }
    }

    public abstract class ManagedEntity : UnmanagedEntity
    {
        [Column(Order = 103)]
        public DateTime LastModifiedDate { get; set; }

        public User ModifiedByUser { get; set; }
    }

    public abstract class TokenEntity : ManagedEntity
    {
        public Guid TokenId { get; set; }
        public DateTime ExpirationDate { get; set; }
    }

    public abstract class HistoricalEntity : UnmanagedEntity
    {
        [Column(Order = 99)]
        public bool MostRecent { get; set; }
        public string Notes { get; set; }
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

}
