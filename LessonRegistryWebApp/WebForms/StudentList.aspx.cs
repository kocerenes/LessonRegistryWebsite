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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentManager studentManager = new StudentManager();
            List<Student> students = studentManager.GetList();
            Repeater1.DataSource = students;
            Repeater1.DataBind();
        }
    }
}