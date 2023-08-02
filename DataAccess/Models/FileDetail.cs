using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class FileDetail
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public byte FileType { get; set; }
        public int MessageId { get; set; }
        public byte IsDeleted { get; set; }

        public virtual Message Message { get; set; } = null!;
    }
}
