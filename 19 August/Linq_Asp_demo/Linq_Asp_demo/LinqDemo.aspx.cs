using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_Asp_demo
{
    public partial class LinqDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var selitem = from ListItem li in ListBox1.Items
                           where li.Selected == true
                           select li.Text;
            foreach(var res in selitem)
            {
                Response.Write(res.ToString()+"<br>");
            }

                       
        }
    }
}