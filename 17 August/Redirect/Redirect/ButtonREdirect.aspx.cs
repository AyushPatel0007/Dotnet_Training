using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Redirect
{
    public partial class ButtonREdirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Dashboard.aspx");
        }
      
        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("https://www.google.com");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("https://www.google.com");

        }
    }
}