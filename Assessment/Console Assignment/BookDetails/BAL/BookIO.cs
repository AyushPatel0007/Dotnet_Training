using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class BookIO
    {
        BookService b = new BookService();

        public string InsertData(int id, string name, string author, string publisher, int price)
        {
            try
            {
                return b.InsertData(id,name,author,publisher,price);
            }catch(Exception ex)
            {
                return "**something went wrong***";
            }
        }
        public object DisplayData1()
        {
           
                return b.DisplayData();
             
        }
        public string UpdateData(int id, string name, string author, string publisher, int price)
        {
            try
            {
                return b.UpdateData(id, name, author, publisher, price);
            }
            catch (Exception ex)
            {
                return "**something went wrong***";
            }
        }
        public string DeleteData(int id)
        {
            try
            {
                return b.DeleteData(id);
            }
            catch (Exception ex)
            {
                return "**something went wrong***";
            }
        }



    }
}
