using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ServerProfilePic
    {
        public int Id { get; set; }
        public int ServerId { get; set; }
        public string ImageName { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public byte IsDeleted { get; set; }

        public virtual Server Server { get; set; } = null!;
    }
}
