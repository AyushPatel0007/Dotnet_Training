using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LInqAssesment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var res1 = (from ListItem stt in ListBox1.Items
                        where stt.Selected == true
                        select stt.Text);
            var res2 = (from ListItem stt in ListBox2.Items
                        where stt.Selected == true
                        select stt.Text);

            var res=res1.Union(res2).ToList();
            foreach(var r in res)
            {
                Response.Write(r+"<br>");
            }
        }
    }
}