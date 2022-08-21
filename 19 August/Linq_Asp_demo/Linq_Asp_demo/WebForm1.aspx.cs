using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_Asp_demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo5;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Display();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Display();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            con.Open();
            Label id = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox email = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox pswd = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            TextBox did = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            SqlDataAdapter dp = new SqlDataAdapter("update students set Sname='" + name.Text + "',Semail='" + email.Text + "',Spassword='" + pswd.Text + "',Departments_Did='" + int.Parse(did.Text) + "' where Sid='" + int.Parse(id.Text) + "' ", con);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
            GridView1.EditIndex = -1;

            Display();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Display();

        }


        public void Display()
        {
            con.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select * from Students", con);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            con.Open();
            Label id = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            SqlDataAdapter dp = new SqlDataAdapter("delete from students where Sid='"+int.Parse(id.Text)+"'", con);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
            GridView1.EditIndex = -1;
            Display();
        }
    }
}