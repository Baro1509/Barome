using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ProfilePic
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ImageName { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public byte IsDeleted { get; set; }

        public virtual UserInfo User { get; set; } = null!;
    }
}
