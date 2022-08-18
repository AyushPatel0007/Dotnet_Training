using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlCrudDemo
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
            if (!IsPostBack)
            {
                DisplayStudent();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into students values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + int.Parse(TextBox4.Text) + "')", con);
            cmd.ExecuteNonQuery();
            DisplayStudent();
            con.Close();
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            connect();
            con.Open();
            SqlCommand cmd = new SqlCommand("DeletebyId", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", TextBox5.Text));
            cmd.ExecuteNonQuery();
            DisplayStudent();
             con.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            connect();
            con.Open();
            //query-> SqlCommand cmd = new SqlCommand("update students set Sname='"+TextBox7.Text+"',Semail='"+ TextBox8.Text + "',Spassword='"+ TextBox9.Text +"',Departments_Did='"+int.Parse(TextBox10.Text) +"' where Sid='"+ TextBox6.Text + "'", con);
            SqlCommand cmd = new SqlCommand("UpdatebyId", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", int.Parse(TextBox6.Text)));
            cmd.Parameters.Add(new SqlParameter("@name", TextBox7.Text));
            cmd.Parameters.Add(new SqlParameter("@email", TextBox8.Text));
            cmd.Parameters.Add(new SqlParameter("@password", TextBox9.Text));
            cmd.Parameters.Add(new SqlParameter("@did", int.Parse(TextBox10.Text)));
            cmd.ExecuteNonQuery();
            DisplayStudent();
            con.Close();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DisplayStudent();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            connect();
            con.Open();
             int id = int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
           string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;

            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;

            string password = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
             int did = int.Parse(((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text);
            SqlCommand cmd = new SqlCommand("update students set Sname='" + name+ "',Semail='" + email + "',Spassword='" + password + "',Departments_Did='" + did + "' where Sid='" + id + "'", con);
             
            cmd.ExecuteNonQuery();
            DisplayStudent();
            con.Close();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            connect();
            con.Open();
            int id = int.Parse(((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text);
             
            SqlCommand cmd = new SqlCommand("delete from student where Sid='"+id+"'", con);

            cmd.ExecuteNonQuery();
            DisplayStudent();
            con.Close();
        }
    }
}