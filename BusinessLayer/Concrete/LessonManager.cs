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
    public class LessonManager : ILessonService
    {
        LessonDAL _lessonDal = new LessonDAL();
        public List<Lesson> GetList()
        {
            return _lessonDal.List();
        }

        public int ReferenceAdd(References reference)
        {
            if (reference.StudentId != null && reference.LessonId != null)
            {
                return _lessonDal.AddReference(reference);
            }
            else
            {
                return -1;
            }
        }
    }
}
