using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        SqlConnection con;

        public SqlConnection SqlConnection2()
        {
             
               con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo;Integrated Security=SSPI");
          
             return con;
        }
    }
}
