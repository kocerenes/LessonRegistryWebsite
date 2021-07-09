using BusinessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessonRegistryWebApp.WebForms
{
    public partial class Lessons : System.Web.UI.Page
    {
        LessonManager lessonManager = new LessonManager();
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DropDownList1.DataSource = lessonManager.GetList();
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();

                DropDownList2.DataSource = studentManager.GetList();
                DropDownList2.DataTextField = "Name";
                DropDownList2.DataValueField = "Id";
                DropDownList2.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            References reference = new References();
            reference.LessonId = short.Parse(DropDownList1.SelectedValue.ToString());
            reference.StudentId = int.Parse(DropDownList2.SelectedValue.ToString());
            lessonManager.ReferenceAdd(reference);
        }
    }
}