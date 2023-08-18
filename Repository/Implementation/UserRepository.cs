using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation {
    public class UserRepository : IUserRepository {
        private IUserInfoDAO _userInfoDAO;

        public UserRepository(IUserInfoDAO userInfoDAO) {
            _userInfoDAO = userInfoDAO;
        }

        public UserInfo Create(UserInfo userInfo) {
            _userInfoDAO.Create(userInfo);
            return _userInfoDAO.GetByEmail(userInfo.Email);
        }

        public void Delete(int id) {
            var db = _userInfoDAO.Get(id);
            db.IsDeleted = (byte) Status.Deleted;
            _userInfoDAO.Update(db);
        }

        public UserInfo Get(int id) {
            return _userInfoDAO.Get(id);
        }

        public List<UserInfo> Get() {
            return _userInfoDAO.Get();
        }

        public UserInfo Login(string email, string password) {
            throw new NotImplementedException();
        }

        public UserInfo Update(UserInfo userInfo) {
            _userInfoDAO.Update(userInfo);
            return _userInfoDAO.GetByEmail(userInfo.Email);
        }
    }
}
