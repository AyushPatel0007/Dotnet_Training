using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface ProductInterface
    {
        bool Insert();
        DataTable Display();
        bool Delete();
         bool Update();
    }
    public interface CategoryInterface
    {
        bool Insert();
        DataTable Display();
        bool Delete();
        bool Update();
    }
}
