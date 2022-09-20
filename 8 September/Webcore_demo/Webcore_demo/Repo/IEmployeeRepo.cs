using System.Collections.Generic;

namespace Webcore_demo.Repo
{
    public interface IEmployeeRepo
    {
        public List<UserDetail> Getdata();
        public void Delete(int id);
        public UserDetail Getbyid(int id);
        public void AddData(UserDetail u);
        public void Update(UserDetail u);
    }
}
