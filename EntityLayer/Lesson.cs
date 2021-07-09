using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Lesson
    {
        private short id;
        private string name;
        private byte quotaMin;
        private byte quotaMax;

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
        public byte QuotaMin
        {
            get { return quotaMin; }
            set { quotaMin = value; }
        }
        public byte QuotaMax
        {
            get { return quotaMax; }
            set { quotaMax = value; }
        }
    }
}
