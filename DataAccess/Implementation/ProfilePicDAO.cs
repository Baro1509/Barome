using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementation {
    public class ProfilePicDAO : DataAccessBase<ProfilePic>, IProfilePicDAO {
        public ProfilePicDAO(ProjectMessageContext context) : base(context) {
        }

        public void Delete(int id) {
            var db = GetByProfilePicId(id);
            db.IsDeleted = (byte)Status.Deleted;
            Update(db);
        }

        public List<ProfilePic> Get() {
            return GetAll().ToList();
        }

        public ProfilePic GetByPath(string path) {
            return GetAll().FirstOrDefault(p => p.ImagePath.Equals(path));
        }

        public ProfilePic GetByProfilePicId(int id) {
            return GetAll().FirstOrDefault(p => p.Id == id);
        }

        public List<ProfilePic> GetByUserId(int id) {
            return GetAll().Where(p => p.UserId == id).ToList();
        }
    }
}
