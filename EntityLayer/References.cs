using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class References
    {
        private int id;
        private int studentId;
        private short lessonId;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public short LessonId
        {
            get { return lessonId; }
            set { lessonId = value; }
        }
    }
}
