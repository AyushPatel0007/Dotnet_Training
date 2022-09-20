using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi_demo.Models;

namespace WebApi_demo.Repository
{
    public class UserRepository : IUserRepository
    {
        private UserManagementEntities db = new UserManagementEntities();

        public List<UserDetail> GetAllUser()
        {
            return db.UserDetails.ToList();
        }

        public UserDetail Userdetail(string username)
        {
            return db.UserDetails.FirstOrDefault(x => x.UserName == username);
        }
    }

}