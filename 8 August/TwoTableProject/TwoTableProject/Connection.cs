using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTableProject
{
    class Connection
    {
        SqlConnection con;
        public SqlConnection Connections()
        {
            con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=Demo;Integrated Security=SSPI");
            return con;
        }
    }
}
