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

                //create table Product(
                //    Pid int primary key identity(1,1),
                //Pname varchar(25),
                //Price int,
                //Cid int FOREIGN KEY REFERENCES Category(Cid)
                //)
                //create table Category(
                //Cid int primary key identity(1,1),
                //Cname varchar(25),
                //)

        SqlConnection con;

        public SqlConnection SqlConnection2()
        {
             
               con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo;Integrated Security=SSPI");
          
             return con;
        }
    }
}
