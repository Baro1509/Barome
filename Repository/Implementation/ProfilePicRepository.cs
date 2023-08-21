using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation {
    public class ProfilePicRepository : IProfilePicRepository{
        private IProfilePicDAO _profilePicDAO;

        public ProfilePicRepository(IProfilePicDAO profilePicDAO) {
            _profilePicDAO = profilePicDAO;
        }

        public ProfilePic Create(ProfilePic pic) {
            Create(pic);
            return _profilePicDAO.GetByPath(pic.ImagePath);
        }

        public void Delete(int id) {
            _profilePicDAO.Delete(id);
        }

        public List<ProfilePic> Get() {
            return _profilePicDAO.Get();
        }

        public ProfilePic GetByProfilePicId(int id) {
            return _profilePicDAO.GetByProfilePicId(id);
        }

        public List<ProfilePic> GetByUserId(int id) {
            return _profilePicDAO.GetByUserId(id);
        }

        public ProfilePic Update(ProfilePic pic) {
            _profilePicDAO.Update(pic);
            return _profilePicDAO.GetByPath(pic.ImagePath);
        }
    }
}
