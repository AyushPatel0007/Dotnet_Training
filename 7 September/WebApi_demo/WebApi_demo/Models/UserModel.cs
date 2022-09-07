using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_demo.Models
{
    public class UserModel
    {
        UserManagementEntities db = new UserManagementEntities();
        public UserDetail ValidateUser(string username, string password)
        {
            return db.UserDetails.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }

    }
}