using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataStudentDataContext dt = new DataStudentDataContext();


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                Display();
        }



        public void Display()
        {
            var res = (from stu in dt.Students
                       select stu);
            GridView1.DataSource = res;
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Display();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            var res = (from stu in dt.Students
                       where stu.Sid == int.Parse(id.Text)
                       select stu).Single();
            dt.Students.DeleteOnSubmit(res);
            dt.SubmitChanges();
            GridView1.EditIndex = -1;
            Display();


           


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox email = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox pswd = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            TextBox did = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            var res = (from stu in dt.Students
                       where stu.Sid == int.Parse(id.Text)
                       select stu).Single();
            res.Sname = name.Text;
            res.Semail = email.Text;
            res.Spassword = pswd.Text;
            res.Departments_Did = int.Parse(did.Text);
            dt.SubmitChanges();
            GridView1.EditIndex = -1;

            Display();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Display();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var res = (from ListItem st in CheckBoxList1.Items
                       where st.Selected == true
                       select st.Text);

            var res1 = (from ListItem stt in ListBox1.Items
                        where stt.Selected == true
                        select stt.Text);


            var res2 = (from ListItem stt in RadioButtonList1.Items
                        where stt.Selected == true
                        select stt.Text);
            foreach (var r in res)
            {
                Response.Write(r+"<br>");
            }
            foreach (var r in res1)
            {
                Response.Write(r + "<br>");
            }
            foreach (var r in res2)
            {
                Response.Write(r + "<br>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Student st = new Student() {
                Sname = TextBox6.Text,
                Semail=TextBox7.Text,
                Spassword=TextBox8.Text,
                Departments_Did=int.Parse(TextBox9.Text)
            
            };
            dt.Students.InsertOnSubmit(st);
            dt.SubmitChanges();
            Display();

        }
    }
}