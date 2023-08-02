using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int ServerId { get; set; }
        public byte IsDeleted { get; set; }

        public virtual Server Server { get; set; } = null!;
    }
}
