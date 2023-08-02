using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Message
    {
        public Message()
        {
            FileDetails = new HashSet<FileDetail>();
            InverseParent = new HashSet<Message>();
        }

        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ChannelId { get; set; }
        public DateTime SendAt { get; set; }
        public byte Type { get; set; }
        public string Content { get; set; } = null!;
        public byte IsDeleted { get; set; }
        public int? ParentId { get; set; }

        public virtual Channel Channel { get; set; } = null!;
        public virtual Message? Parent { get; set; }
        public virtual UserInfo Sender { get; set; } = null!;
        public virtual ICollection<FileDetail> FileDetails { get; set; }
        public virtual ICollection<Message> InverseParent { get; set; }
    }
}
