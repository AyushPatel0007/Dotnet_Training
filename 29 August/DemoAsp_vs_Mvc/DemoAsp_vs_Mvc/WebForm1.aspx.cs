using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoAsp_vs_Mvc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["textw"] = TextBox1.Text;
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = ViewState["textw"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx?name=" + TextBox1.Text+"&name1="+"Ayush");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Cookies["name"].Value = TextBox2.Text;
            Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(1);
            Label2.Text = "Cookie Created";
            TextBox2.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] == null)
            {
                Label3.Text = "no Cookie found";
            }
            else
            {
                Label3.Text=Request.Cookies["name"].Value;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (Application["count"] != null)
            {
                c= Convert.ToInt32(Application["count"].ToString());

 
            }
             
            c = c + 1;
            Application["count"] = c;
            Label4.Text = "Here total reach is "+c.ToString();

           

        }
    }
}