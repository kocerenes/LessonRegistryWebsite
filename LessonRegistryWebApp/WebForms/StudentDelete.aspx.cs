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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            StudentManager studentManager = new StudentManager();
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            Response.Write(id);
            student.Id = id;
            studentManager.Delete(student.Id);
            Response.Redirect("StudentList.aspx");
        }
    }
}