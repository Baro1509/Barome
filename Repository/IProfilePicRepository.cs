using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IProfilePicRepository {
        public ProfilePic GetByProfilePicId(int id);
        public List<ProfilePic> GetByUserId(int id);
        public void Delete(int id);
        public ProfilePic Create(ProfilePic pic);
        public ProfilePic Update(ProfilePic pic);
        public List<ProfilePic> Get();
    }
}
