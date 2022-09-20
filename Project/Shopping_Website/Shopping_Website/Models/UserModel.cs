using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_Website.Models
{
    public class UserModel
    {
        public UserDetail ValidateUser(string username, string password)
        {
            Shopping_DBEntities db = new Shopping_DBEntities();
            UserDetail res = db.UserDetails.FirstOrDefault(x => x.Username == username && x.Password == password);
            return res;
        }
    }
}