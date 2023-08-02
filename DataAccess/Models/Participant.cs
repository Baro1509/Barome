using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Participant
    {
        public int UserId { get; set; }
        public int ServerId { get; set; }
        public DateTime JoinedDate { get; set; }
        public byte IsDeleted { get; set; }

        public virtual Server Server { get; set; } = null!;
        public virtual UserInfo User { get; set; } = null!;
    }
}
