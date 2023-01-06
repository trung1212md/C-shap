using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luyentap1
{
    internal class Program
    {


        class Student 
        {
            private int rollno;
            private string name;
            private string course;
            private int feepaid;

            public Student(int rollno,string name ,string course)
            {
                this.rollno = rollno;
                this.name = name;  
                this.course = course;   

            }
            public void Payment(int amount)
            {
                feepaid += amount;
            }
            public void Print()
            {
                Console.WriteLine("rollno" + rollno);
                Console.WriteLine("Name"+name);
                Console.WriteLine("Course:"+course);
                Console.WriteLine("FeePaid:"+feepaid);
            }
            public int DueAmount
            {
                get
                {
                    return feepaid-feepaid;
                }
            }
            public int TotalFee
            { 
                get
                {
                    return course == "C#" ? 2000 : 3000;
                }
            }

           
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("===========s1============");
            Student s1 = new Student(1, "Anna", "C#");
            s1.Payment(800);
            s1.Print();
            Console.WriteLine(s1.DueAmount);
            Console.WriteLine("=======S2==========");
            Student S2 = new Student(2, "john", "ASP.Net");
            S2.Payment(1600);
            S2.Print();
        }
    }
}
