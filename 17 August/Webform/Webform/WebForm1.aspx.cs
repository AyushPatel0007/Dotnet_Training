using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Preinit(object sender,EventArgs e)
        {
            Response.Write("Page_Preinit<br>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init<br>");

        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_InitComplete<br>");

        }
        protected void OnPreLoad(EventArgs e)
        {
            Response.Write("OnPreLoad<br>");

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load<br>");

        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page_LoadComplete<br>");

        }
        protected void OnPreRender( EventArgs e)
        {
            Response.Write("OnPreRender<br>");

        }
        protected void OnSaveStateComplete( EventArgs e)
        {
            Response.Write("OnSaveStateComplete<br>");

        }

        protected void UnLoad(object sender, EventArgs e)
        {
            Response.Write("UnLoad<br>");

        }



    }
}