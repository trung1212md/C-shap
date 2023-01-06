using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phieubai1
{
    internal class Program
    {
        class Student
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int mark { get; set; }

            public int scholarship { get; set; }

            public int hocbong(int mark)
            {
                if(mark>8)
                {
                    return 500;

                }
                else if(mark>=7&&mark<=8)
                {
                    return 300;
                }
                else
                {
                    return 0;
                }

            }
            public Student()
            {
                Id = "default";
                Name= "default";
                mark = 0;
                scholarship = 0;
            }
            public Student(int mark)
            {
                this.mark = mark;
            }
            public Student(string id, string name, int mark, int scholarship)
            {
                Id = id;
                Name = name;
                this.mark = mark;
                this.scholarship = scholarship;
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("id:"+student.Id);
            Console.WriteLine("Name:" + student.Name);
            Console.WriteLine("mark:" + student.mark);
            Console.WriteLine("scholarship:" + student.scholarship);
            Console.WriteLine("ket qua" +student.hocbong(student.mark));

            Student student1 = new Student(8);
            Console.WriteLine(student1.Id = "A001");
            Console.WriteLine(student1.Name="trung");
            Console.WriteLine(student.scholarship = 300);
            Console.WriteLine(student1.hocbong(student1.mark));

            Student student2 = new Student("001","hoa",8,400);
            Console.WriteLine("iD:" + student2.Id);
            Console.WriteLine("iD:" + student2.Name);
            Console.WriteLine("iD:" + student2.mark);
            Console.WriteLine("iD:" + student2.scholarship);
            Console.WriteLine(student2.hocbong(student2.mark));
        }
    }
}
