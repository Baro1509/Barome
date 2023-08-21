using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public interface IProfilePicDAO {
        public ProfilePic GetByProfilePicId(int id);
        public List<ProfilePic> GetByUserId(int id);
        public ProfilePic GetByPath(string path);
        public void Delete(int id);
        public void Create(ProfilePic pic);
        public void Update(ProfilePic pic);
        public List<ProfilePic> Get();
    }
}
