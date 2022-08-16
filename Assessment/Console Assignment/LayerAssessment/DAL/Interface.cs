using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL
{
    public interface Interface1
    {
          DataTable DisplayProduct();
          bool InsertProduct(Product p);
          bool DeleteProduct(int id);
          bool UpdatebyName(int i, string name);
          bool UpdatebyPrice(int i, int price);

          bool UpdatebyCategoryId(int i, int cid);

          DataTable DisplayAll();
    }

    public interface Interface2
    {
          bool InsertCategory(Category e);


          DataTable DisplayCategory();


          bool DeleteCategory(int id);
          bool UpdateCategory(int id, string s);
    }
}
