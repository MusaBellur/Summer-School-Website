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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityStudents students = new EntityStudents();
            students.StuName = TxtName.Text;
            students.Lastname = TxtLastName.Text;
            students.Number = TxtNumber.Text;
            students.Password = TxtPassword.Text;
            students.Photo = TxtPhoto.Text;
            BLLStudents.AddStudentBLL(students);

        }
    }
}