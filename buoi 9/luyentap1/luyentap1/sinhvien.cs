using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyentap1
{
     class sinhvien
    {
        private int id;
        private string name;
        private int age;

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

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public sinhvien(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            
        }
    }
}
