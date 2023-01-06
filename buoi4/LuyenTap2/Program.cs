using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap2
{
    internal class Program
    {
        class Employee
        {
            public string id { get; set; }  
            public string name { get; set; }    
            public int age { get; set; }
            public int salary { get; set; }
            public int commisiton { get; set; }
            public int total {

                get
                {
                    return salary+commisiton;
                }
            }
            //Phương thức khởi tạo 0 tham số
            public Employee()
            {
                id = "default_id";
                name = "default _name";
                age = 0;
                salary = 0;
                commisiton = 0;

            }
            //Phương thức khởi tạo 5 tham số
            public Employee(string id, string name, int age, int salary, int commisiton)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.salary = salary;
                this.commisiton = commisiton;
            }

            public Employee (string id)
            {
                this.id = id;

            }

            public void Input()
            {
                Console.WriteLine("nhap ID:");
                id=Console.ReadLine();
                Console.WriteLine("nhap name");
                name=Console.ReadLine();
                Console.WriteLine("nhap age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap salary");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap commision");
                commisiton = Convert.ToInt32(Console.ReadLine());

            }

            public void OutPut()
            {
                Console.WriteLine("==============Employee information");
                Console.WriteLine("id" + id);
                Console.WriteLine("name" + name);
                Console.WriteLine("age"+age);
                Console.WriteLine("salary"+salary);
                Console.WriteLine("commision"+commisiton);
                Console.WriteLine("total"+total);
            }
        }


        static void Main(string[] args)
        {
            // su dung phuong thuc ko tham so
            Employee emp = new Employee();
            emp.Input();
            emp.OutPut();

            //su dung phuong thuc khoi tao 5 tham so
            Employee emp1 = new Employee("e02", "Thu Hang", 30, 3000, 500);
            emp1.OutPut();
            //Sử dụng phương thức khởi tạo 1 tham số
            Employee emp3 = new Employee("e03");
            emp3.name = "van tien";
            emp3.age = 35;
            emp3.salary = 5000;
            emp3.commisiton = 1000;
            emp3.OutPut();


        }
    }
}
