using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        StudentDAL _studentDal = new StudentDAL();

        public void Add(Student student)
        {
            if (student.Name != null && student.Surname !=null && student.Number != null && student.Password != null && student.Photo != null)
            {
                _studentDal.Add(student);
            }
            else
            {
                
            }
        }

        public bool Delete(int id)
        {
            if (id > 0)
            {
                return _studentDal.Delete(id);
            }
            else
            {
                return false;
            }
        }

        public List<Student> GetList()
        {
            return _studentDal.List();
        }

        public List<Student> GetListByID(int id)
        {
            return _studentDal.ListById(id);
        }

        public bool Update(Student student)
        {
            if (student.Name != null && student.Surname != null && student.Number != null && student.Password != null && student.Photo != null && student.Balance <0)
            {
                return _studentDal.StudentUpdate(student);
            }
            else
            {
                return false;
            }
        }
    }
}
