using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public interface IUserInfoDAO {
        public UserInfo Get(int id);
        public UserInfo GetByEmail(string email);
        public void Delete(int id);
        public void Create(UserInfo user);
        public void Update(UserInfo user);
        public List<UserInfo> Get();

        public UserInfo Login(string username, string password);
    }
}
