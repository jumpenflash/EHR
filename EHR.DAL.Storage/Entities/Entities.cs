using EHR.DAL.Entities;
using EHR.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Storage.Entities
{
    public class File : ManagedEntity
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string MimeType { get; set; }
        public long Size { get; set; }

        public FileGroup FileGroup { get; set; }
    }

    public class FileGroup : ManagedEntity
    {
        public FileGroup ParentFileGroup { get; set; }

        public ICollection<File> Files { get; set; }
        public ICollection<FileGroup> ChildFileGroups { get; set; }
    }
}
