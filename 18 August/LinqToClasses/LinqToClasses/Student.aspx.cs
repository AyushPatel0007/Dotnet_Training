using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqToClasses
{
    public partial class Student1 : System.Web.UI.Page
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

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
            try
            {
                Student s = new Student()
                {
                    Sname = Convert.ToString(TextBox2.Text),
                    Semail = Convert.ToString(TextBox3.Text),
                    Spassword = Convert.ToString(TextBox4.Text),
                    Departments_Did = int.Parse(TextBox5.Text)
                };
                dc.Students.InsertOnSubmit(s);
                dc.SubmitChanges();
            }catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = (from c in dc.Students
                             where c.Sid == int.Parse(TextBox1.Text)
                             select c).Single();
                TextBox1.Text = s.Sid.ToString();
                TextBox2.Text = s.Sname.ToString();
                TextBox3.Text = s.Semail.ToString();
                TextBox4.Text = s.Spassword.ToString();
                TextBox5.Text = s.Departments_Did.ToString();
                dc.SubmitChanges();
            }catch(Exception ex)
            {
                Response.Write("Id not found");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Student s = (from c in dc.Students
                         where c.Sid == int.Parse(TextBox1.Text)
                         select c).Single();

            s.Sname = Convert.ToString(TextBox2.Text);
            s.Semail = Convert.ToString(TextBox3.Text);
            s.Spassword = Convert.ToString(TextBox4.Text);
            s.Departments_Did = int.Parse(TextBox5.Text);
            dc.SubmitChanges();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Student s = (from c in dc.Students
                         where c.Sid == int.Parse(TextBox1.Text)
                         select c).Single();
            dc.Students.DeleteOnSubmit(s);
            dc.SubmitChanges();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";


        }
    }
}