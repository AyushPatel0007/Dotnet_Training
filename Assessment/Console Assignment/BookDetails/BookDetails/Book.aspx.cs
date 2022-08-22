using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace BookDetails
{
    public partial class Book : System.Web.UI.Page
    {
        BookIO b = new BookIO();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                DisplayData();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            DisplayData();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex; 
            DisplayData();

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = "";
            try
            {
               res= b.InsertData(int.Parse(TextBox6.Text), TextBox7.Text, TextBox8.Text, TextBox9.Text, int.Parse(TextBox10.Text));

            }catch(Exception ex)
            {
                Response.Write("*Enter format wrong**");
            }
            Response.Write("<script>alert('" + res + "')</script>");
            DisplayData();


        }

        public void DisplayData()
        {
            
           
            GridView1.DataSource = b.DisplayData1();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string res = "";
            try
            {
                Label id = GridView1.Rows[e.RowIndex].FindControl("label2") as Label;
                TextBox name = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
                TextBox author = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
                TextBox publisher = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
                TextBox price = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
                res=b.UpdateData(int.Parse(id.Text), name.Text, author.Text, publisher.Text, int.Parse(price.Text));
                GridView1.EditIndex = -1;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                GridView1.EditIndex = -1;

                DisplayData();
            }
            Response.Write("<script>alert('" + res + "')</script>");
            DisplayData();
        }


        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string res="";
            try
            {
                Label id = GridView1.Rows[e.RowIndex].FindControl("Label2") as Label;
                res = b.DeleteData(Convert.ToInt32(id.Text));
                DisplayData();
            }
            catch (Exception ex)
            {
                Response.Write("*something wen wrong**");
            }
            Response.Write("<script>alert('" + res + "')</script>");
            DisplayData();


        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}