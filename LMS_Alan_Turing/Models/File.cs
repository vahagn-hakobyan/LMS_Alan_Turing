using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class File
    {
        public int? FolderParentId { get; set; }
        public int? FolderChildId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public bool? Accessibility { get; set; }
        public byte[] Content { get; set; }

        public virtual Folder FolderParent { get; set; }
    }
}
