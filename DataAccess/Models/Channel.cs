using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Channel
    {
        public Channel()
        {
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public byte AppearOrder { get; set; }
        public byte IsDeleted { get; set; }
        public int ServerId { get; set; }

        public virtual Server Server { get; set; } = null!;
        public virtual ICollection<Message> Messages { get; set; }
    }
}
