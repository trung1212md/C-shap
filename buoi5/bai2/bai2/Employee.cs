using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Employee
    {

        private string id;
        private string name;
        private int age;
        private int workingdays;
        private double salary;
        private const int PRICE = 50;

        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Workingdays { get { return workingdays; } set { workingdays = value; } }

        public double getsalary()
        {
            return (double)salary*PRICE;
        }

        public void input()
        {
            Console.WriteLine("nhap id");
            id = Console.ReadLine();
            Console.WriteLine("nhap name");
            name = Console.ReadLine();
            Console.WriteLine("nhap tuoi");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ngay cong");
            Workingdays = Convert.ToInt32(Console.ReadLine());

        }
        public void output()
        {
            Console.WriteLine("id:"+id);
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
            Console.WriteLine("ngay cong:" + workingdays);
            Console.WriteLine("Luong:" + getsalary());
        }

    }
}
