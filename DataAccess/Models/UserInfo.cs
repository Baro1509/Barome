using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            Messages = new HashSet<Message>();
            ProfilePics = new HashSet<ProfilePic>();
            Servers = new HashSet<Server>();
        }

        public int Id { get; set; }
        public string? DisplayName { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string? Bio { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public byte IsDeleted { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<ProfilePic> ProfilePics { get; set; }
        public virtual ICollection<Server> Servers { get; set; }
    }
}
