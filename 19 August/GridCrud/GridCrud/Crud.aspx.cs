using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
namespace GridCrud
{
    public partial class Crud : System.Web.UI.Page
    {
        StudentIO s = new StudentIO();
        
        public void DisplayStudent()
        {
             
            
            GridView1.DataSource = s.Displaystudent();
            GridView1.DataBind();
             

            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayStudent();

            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            s.Deletestudent(Convert.ToInt32(id.Text));  
            DisplayStudent();

        }

        
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            DisplayStudent();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            Label id = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox email = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox pswd = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            TextBox did = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            s.Updatestudent(int.Parse(id.Text), name.Text, email.Text, pswd.Text, int.Parse(did.Text));
            GridView1.EditIndex = -1;
            DisplayStudent();
            

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DisplayStudent();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res="";
            try
            {
                res = s.Insertstudent(TextBox6.Text, TextBox7.Text, TextBox8.Text, int.Parse(TextBox9.Text));
            }catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                DisplayStudent();
                return;
            }
            Response.Write("<script>alert('"+res+"')</script>");
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            DisplayStudent();
         }
    }
}