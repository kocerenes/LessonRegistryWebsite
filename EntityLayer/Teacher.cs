using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Teacher
    {
        private short id;
        private string name;
        private string surname;
        private short branch;

        public short Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public short Branch
        {
            get { return branch; }
            set { branch = value; }
        }
    }
}
