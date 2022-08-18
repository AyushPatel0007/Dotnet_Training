using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlDemo
{
    public partial class Xml2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = DropDownList1.SelectedItem.Value;
            if (s != string.Empty)
            {
                XmlDataSource1.XPath = "/Employees/Employee[ Country='" + s + "']";
            }
            else
            {
                XmlDataSource1.XPath = "/Employees/Employee";
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}