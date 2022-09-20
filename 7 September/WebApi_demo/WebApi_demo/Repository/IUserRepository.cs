using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_demo.Models;

namespace WebApi_demo.Repository
{
    public interface IUserRepository
    {
        List<UserDetail> GetAllUser();
        UserDetail Userdetail(string username);
    }
}
