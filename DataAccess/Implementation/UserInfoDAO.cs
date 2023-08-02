using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementation {
    public class UserInfoDAO : DataAccessBase<UserInfo>, IUserInfoDAO {
        public UserInfoDAO(ProjectMessageContext context) : base(context) {
        }

        public void Delete(int id) {
            var user = Get(id);
            user.IsDeleted = (byte) Status.Deleted;
            Update(user);
        }

        public UserInfo Get(int id) {
            return GetAll().FirstOrDefault(p => p.Id == id && p.IsDeleted == (byte) Status.Available);
        }

        public List<UserInfo> Get() {
            return GetAll().ToList();
        }

        public UserInfo Login(string username, string password) {
            throw new NotImplementedException();
        }

        private UserInfo LoginWithUserName(string username, string password) {
            var userInfo = GetAll().FirstOrDefault(p => p.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && p.Password.Equals(password) && p.IsDeleted == (byte) Status.Available);
            return userInfo != null ? userInfo : LoginWithEmail(username, password);
        }

        private UserInfo LoginWithEmail(string email, string password) {
            return GetAll().FirstOrDefault(p => p.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && p.IsDeleted == (byte) Status.Available);
        }
    }
}
