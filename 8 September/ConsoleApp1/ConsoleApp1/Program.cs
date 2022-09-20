using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    public class Program
    {
        public static string Encrypt(string str)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(str);
            return Convert.ToBase64String(b);


        }

        public static string Decrypt(string str)
        {
            byte[] b;
            string decrp;
            try
            {
                b = Convert.FromBase64String(str);
                decrp = System.Text.ASCIIEncoding.ASCII.GetString(b);

            }
            catch (FormatException e)
            {
                decrp = "";
            }
            return decrp;


        }

        static void Main(string[] args)
        {
            string s = "Abc12ello dear";
            s = Encrypt(s);
            s = Decrypt(s);
            

            BusinessClass dt = new BusinessClass();
            //dt.ayega = new DepartmentData();
            var res = dt.rightvalue(new DepartmentData());


        }
    }


    public interface IDepartment
    {
        List<Department> GetData();
    }
}
