using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IUserRepository {
        public UserInfo Create(UserInfo userInfo);
        public UserInfo Update(UserInfo userInfo);
        public UserInfo Get(int id);
        public void Delete(int id);
        public List<UserInfo> Get();

        public UserInfo Login(string email, string password);
    }
}
