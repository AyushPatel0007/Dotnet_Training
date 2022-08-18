using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con;

        public void connect()
        {
            con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo5;Integrated Security=True");

        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        
 
        protected void Button1_Click(object sender, EventArgs e)
        {
            connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into customer values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.SelectedItem.Value + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
                        
        }

        public void GridDispllay()
        {
            connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", con);
            SqlDataReader rd = cmd.ExecuteReader();
            GridView1.DataSource = rd;
            GridView1.DataBind();
            con.Close();



        }
         
    }
}