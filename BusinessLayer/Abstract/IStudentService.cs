using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentService
    {
        void Add(Student student);
        bool Delete(int id);
        bool Update(Student student);
        List<Student> GetList();
        List<Student> GetListByID(int id);
    }
}
