using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luyentap4
{
    internal class Program
    {
        public class Employee4
        {
        
        
        public string id;
        public string name;
        public Employee4()
        {

        }
        public Employee4(string name,string id)
        {
            this.name = name;
            this.id = id;
        }
            public static int employeeCounter;

            public static int AddEmployee()
            {
                return employeeCounter;
            }
        }
        class MainClass:Employee4
        {


        static void Main(string[] args)
        {
                Console.WriteLine("Enter the emPloyee's name");
                string name =Console.ReadLine();
                Console.WriteLine("Enter the Employee's ID");
                string id =Console.ReadLine();

                // tạo cáu hình đối tượng Employee e.
                Employee4 e=new Employee4();
                Console.WriteLine("Enter the Current of employees");
                string n=Console.ReadLine();

                Employee4.employeeCounter=Int32.Parse(n);
                Employee4.AddEmployee();
                Console.WriteLine($"name:{e.name}");
                Console.WriteLine($"ID:{e.id}");
        }
        }

    }
}
