using BusinessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessonRegistryWebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Number = txtNumber.Text;
            student.Password = txtPassword.Text;
            student.Photo=txtPhoto.Text;
            student.Balance = decimal.Parse(txtBalance.Text);
            
            StudentManager studentManager = new StudentManager();
            studentManager.Add(student);
            Response.Redirect("StudentList.aspx");
        }
    }
}