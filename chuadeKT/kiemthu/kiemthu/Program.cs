using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static kiemthu.Program;

namespace kiemthu
{
    public static class Program
    {
       public  class Employee
        {
            // thêm public
            String name;
             public int hoursWorked;
             public  float hourlyRate;
             public   float tax;
             public  float grossPay;
             public  float netPay;

            
            public Employee(String name, int hoursWorked, float hourlyRate )
            {
                this.name = name;
                this.hoursWorked = hoursWorked;
                this.hourlyRate = hourlyRate;
            }
            
            // them ham khoi tao ko doi
            public Employee()
            {
            }
            // lay ra ten
            public String getName()
            {
                return name;
            }
            // lay  hours
            

            public void calculatePay()
            {
                int payableHours;

                if (hoursWorked <= 40)
                {
                    payableHours = hoursWorked;
                }
                else
                {
                    payableHours = 40 + (hoursWorked - 40) * 3 / 2;
                }
                // sua hoursWorked thành payableHours 
                grossPay = payableHours * hourlyRate;
                // xuat ra Gross
                Console.WriteLine("Gross:" + grossPay);


                if (grossPay >= 200)
                {

                    // tax bi sai 
                   // tax = grossPay * 20 / 100;


                    //sua loi tax
                    tax = (grossPay * 20 / 100)-40;
                }
                Console.WriteLine("tax:" + tax);
                netPay = grossPay - tax;

                Console.WriteLine("NetPay" + netPay);
            }// end calculatePay()

            public  void wrapper()
            {

                Console.WriteLine("nhap ten");
                name=Console.ReadLine();
                Console.WriteLine("nhap hoursWorked");
               hoursWorked=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap hourlyRate");
                hourlyRate=Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
           
            Employee employee = new Employee();
            for(int i=0;i<4;i++)
            {

            employee.wrapper();
            employee.calculatePay();
            }

            


        }
    }
}
