using System.Collections.Generic;
using System.Linq;

namespace Webcore_demo.Repo
{

    public class EmployeeRepo:IEmployeeRepo
    {
        private AppDbContext db;
        public EmployeeRepo(AppDbContext d)
        {
            db = d;
        }
        public List<UserDetail> Getdata()
        {             

            List<UserDetail> e =  db.UserDetails.ToList();
            return e;
        }
        public void Delete(int id)
        {

            var res=db.UserDetails.FirstOrDefault(x=>x.Id==id);
            db.UserDetails.Remove(res);
            db.SaveChanges();

            
        }
        public UserDetail Getbyid(int id)
        {
             
            return db.UserDetails.FirstOrDefault(x=>x.Id==id);
        }
        public void AddData(UserDetail u)
        {
            db.UserDetails.Add(u);
            db.SaveChanges();
         }

        public void Update(UserDetail u)
        {
            var res = db.UserDetails.FirstOrDefault(x => x.Id == u.Id);
            res.UserName = u.UserName;
            res.Roles = u.Roles;
            db.SaveChanges();
        }

    }
}
