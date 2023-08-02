using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Server
    {
        public Server()
        {
            Channels = new HashSet<Channel>();
            Roles = new HashSet<Role>();
            ServerProfilePics = new HashSet<ServerProfilePic>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int CreatorId { get; set; }
        public byte IsDeleted { get; set; }

        public virtual UserInfo Creator { get; set; } = null!;
        public virtual ICollection<Channel> Channels { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<ServerProfilePic> ServerProfilePics { get; set; }
    }
}
