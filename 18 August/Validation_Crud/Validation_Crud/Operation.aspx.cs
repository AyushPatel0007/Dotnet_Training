using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation_Crud
{
    public partial class Operation : System.Web.UI.Page
    {
        SqlConnection con;
        public void connect()
        {
            con = new SqlConnection("Data Source=DEL1-LHP-N82207\\MSSQLSERVER01;Initial Catalog=demo5;Integrated Security=True");
        }
        public void DisplayStudent()
        {
            connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Students", con);
            SqlDataReader r = cmd.ExecuteReader();
            GridView1.DataSource = r;
            GridView1.DataBind();
            con.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayStudent();

            }

        }

         

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("lid") as Label;
            connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Students where Sid='" + Convert.ToInt32(id.Text) + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayStudent();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("txt_Name") as TextBox;
            TextBox email = GridView1.Rows[e.RowIndex].FindControl("txt_Email") as TextBox;
            TextBox pswd = GridView1.Rows[e.RowIndex].FindControl("txt_pswd") as TextBox;
            TextBox did = GridView1.Rows[e.RowIndex].FindControl("txt_Did") as TextBox;
            connect();
            con.Open();
            //updating the record  
            SqlCommand cmd = new SqlCommand("update students set Sname='" + name.Text + "',Semail='" + email.Text + "',Spassword='" + pswd.Text + "',Departments_Did='" + int.Parse(did.Text) + "' where Sid='" + int.Parse(id.Text) + "'", con);
            cmd.ExecuteNonQuery();
            GridView1.EditIndex = -1;
            DisplayStudent();
            con.Close();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DisplayStudent();
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            DisplayStudent();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into students values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + int.Parse(TextBox5.Text) + "')", con);
            cmd.ExecuteNonQuery();
            DisplayStudent();
            con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}