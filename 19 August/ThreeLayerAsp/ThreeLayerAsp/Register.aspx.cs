using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace ThreeLayerAsp
{
    public partial class Register : System.Web.UI.Page
    {
        StudentIO b = new StudentIO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Display();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (b.AddStu(Convert.ToString(TextBox1.Text), Convert.ToString(TextBox2.Text), Convert.ToString(TextBox3.Text), int.Parse(TextBox4.Text)))
            {
                Response.Write("*****inserted*********");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";

                Display();
            }
            else
            {
                Response.Write("Something went wrong");
            }
        }
        public void Display()
        {
 
            GridView1.DataSource=b.DisplayStudent();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (b.Deletebyid(int.Parse(TextBox5.Text)))
            {
                Response.Write("*****deleted*********");
                TextBox5.Text = "";
                Display();
            }
            else
            {
                Response.Write("Something went wrong");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (b.UpdateStudent(Convert.ToInt32(TextBox5.Text), Convert.ToString(TextBox1.Text), Convert.ToString(TextBox2.Text), Convert.ToString(TextBox3.Text), int.Parse(TextBox4.Text)))
            {
                Response.Write("*****Updated*********");
                TextBox5.Text = "";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                Display();
            }
            else
            {
                Response.Write("**Id not find**");
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlDataReader s = b.Findbyid(int.Parse(TextBox5.Text));
            while (s.Read())
            {
                TextBox1.Text = s["Sname"].ToString();
                TextBox2.Text = s["Semail"].ToString();
                TextBox3.Text = s["Spassword"].ToString();
                TextBox4.Text = s["Departments_Did"].ToString();
            }
 
        }
    }
}