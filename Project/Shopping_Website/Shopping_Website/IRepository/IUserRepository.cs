using Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Website.IRepository
{
    public interface IUserRepository
    {
          List<UserDetail> GetAllUser();
         int InsertData(UserDetail userDetail);
        UserDetail GetUser(string username);
        string GetRole(int Role);
        int GetRole(string Role);
        List<RoleDetail> GetAllRoles();
        UserDetail SelectData(int id);
        int UpdateData(UserDetail item);
        List<UserDetail> GetAllData();
     }
}
