using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class WebEvent_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            log("<<page_load>>");   
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            log("<<page_prerender>>");
        }
        protected void CtrlChanged(object sender, EventArgs e)
        {
            string s = ((Control)sender).ID;
            log(s + " changes");
        }



        private void log(string entry)
        {
            Lstevents.Items.Add(entry);
            Lstevents.SelectedIndex = Lstevents.Items.Count - 1;

        }
         
    }
}