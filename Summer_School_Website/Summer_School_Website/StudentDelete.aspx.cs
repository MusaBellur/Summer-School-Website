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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["StuId"]);
            Response.Write(x);
            EntityStudents students = new EntityStudents();
            students.StuId = x;
            BLLStudents.DelStudentBLL(students.StuId);
            Response.Redirect("StudentList.aspx");
        }
    }
}