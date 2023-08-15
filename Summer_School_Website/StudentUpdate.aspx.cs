using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace Summer_School_Website
{
    public partial class StudentUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["StuId"]);
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityStudents> update = BLLStudents.BllUpdList(x);
                TxtName.Text = update[0].StuName.ToString();
                TxtLastName.Text = update[0].Lastname.ToString();
                TxtNumber.Text = update[0].Number.ToString();
                TxtPassword.Text = update[0].Password.ToString();
                TxtPhoto.Text = update[0].Photo.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityStudents students = new EntityStudents();
            students.StuName = TxtName.Text;
            students.Lastname = TxtLastName.Text;
            students.Number = TxtNumber.Text;
            students.Password = TxtPassword.Text;
            students.Photo = TxtPhoto.Text;
            students.StuId = Convert.ToInt32(TxtId.Text);
            BLLStudents.BllUpdate(students);
            Response.Redirect("StudentList.aspx");
        }
    }
}