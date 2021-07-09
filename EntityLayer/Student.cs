using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Student
    {
        private int id;
        private string name;
        private string surname;
        private string number;
        private string photo;
        private string password;
        private decimal balance;

        public int Id 
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
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
