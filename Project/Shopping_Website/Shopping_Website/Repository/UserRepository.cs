using Shopping_Website.IRepository;
using Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Shopping_Website.Repository
{
    public class UserRepository: IUserRepository
    {
        Shopping_DBEntities db = new Shopping_DBEntities();
        public List<UserDetail> GetAllUser()
        {
            return db.UserDetails.ToList();
        }

      
 
        public int InsertData(UserDetail userDetail)
        {

            // return userrepository.Insert(userDetail);
            db.UserDetails.Add(userDetail);
            return db.SaveChanges();
        }


        
        public UserDetail GetUser(string username)
        {
            UserDetail res = db.UserDetails.FirstOrDefault(x => x.Username == username);
            return res;
        }


 
        public string GetRole(int Role)
        {
            var res = db.RoleDetails.FirstOrDefault(xx => xx.Id == Role);


            return res.Name;
        }
       
        public int GetRole(string Role)
        {
            var res = db.RoleDetails.FirstOrDefault(xx => xx.Name == Role);


            return res.Id;
        }

    
        public List<RoleDetail> GetAllRoles()
        {
            List<RoleDetail> list = db.RoleDetails.ToList();
            return list;
        }

    
        public UserDetail SelectData(int id)
        {
            var res = db.UserDetails.FirstOrDefault(x => x.Id == id);
            return res;
        }

      
        public int UpdateData(UserDetail item)
        {
            var res = db.UserDetails.FirstOrDefault(x => x.Id == item.Id);
            res.Username = item.Username;
            res.Email = item.Email;
            res.Password = item.Password;
            res.Address = item.Address;
            res.Contactno = item.Contactno;
            return db.SaveChanges();
        }
   
        public List<UserDetail> GetAllData()
        {
            var res = db.UserDetails.ToList();
            return res;
        }



      


    }
}