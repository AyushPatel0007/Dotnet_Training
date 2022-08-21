using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practise_Class
{
    public partial class Demo_Class : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataClassesDataContext dt = new DataClassesDataContext();
            //GridView1.DataSource = from s in dt.Students
            //                       orderby s.Semail descending
            //                       select s;
            //GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var res = CheckBoxList1.Items.Cast<ListItem>().Where(n => n.Selected).Select(n => n.Value);
            var re = RadioButtonList1.Items.Cast<ListItem>().Where(x => x.Selected).Select(x => x.Value);
             foreach(var r in res)
             {
                Response.Write(r);
             }
            foreach (var r in re)
            {
                Response.Write(r);
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {

        }
    }
}