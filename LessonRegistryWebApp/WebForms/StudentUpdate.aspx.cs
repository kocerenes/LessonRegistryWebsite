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
    public partial class StudentUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            txtId.Text = id.ToString();
            txtId.Enabled = false;
            StudentManager studentManager = new StudentManager();

            if (Page.IsPostBack == false)
            {
                List<Student> students = studentManager.GetListByID(id);
                txtName.Text = students[0].Name.ToString();
                txtSurname.Text = students[0].Surname.ToString();
                txtNumber.Text = students[0].Number.ToString();
                txtPhoto.Text = students[0].Photo.ToString();
                txtPassword.Text = students[0].Password.ToString();
                txtBalance.Text = students[0].Balance.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = Convert.ToInt32(txtId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Number = txtNumber.Text;
            student.Photo = txtPhoto.Text;
            student.Password = txtPassword.Text;
            student.Balance =Convert.ToDecimal(txtBalance.Text);
            Response.Redirect("StudentList.aspx");
        }
    }
}