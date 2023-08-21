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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityLessons> list = BLLessons.BLLesList();
                DropDownList1.DataSource = list;
                DropDownList1.DataTextField = "LesName";
                DropDownList1.DataValueField = "LesId";
                DropDownList1.DataBind();

                List<EntityStudents> list1 = BLLStudents.BllList();
                DropDownList2.DataSource = list1;
                DropDownList2.DataTextField = "StuId";
                DropDownList2.DataValueField = "StuId";
                DropDownList2.DataBind();

                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityAppForm form = new EntityAppForm();
            form.AppStuId = int.Parse(DropDownList2.SelectedValue.ToString());
            form.AppLesId = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLessons.BLLAddDemand(form);
        }
    }
}