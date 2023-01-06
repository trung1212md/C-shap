using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemthubug
{
    internal class Program
    {
        class Employee
        {
            String name;
            int hoursWorked;
            float hourlyRate;
            float tax;
            float grossPay;
            float netPay;

            public Employee(String name, int hoursWorked, float hourlyRate)
            {
                this.name = name;
                this.hoursWorked = hoursWorked;
                this.hourlyRate = hourlyRate;
            }

            public String getName()
            {
                return name;
            }

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

                grossPay = hoursWorked * hourlyRate;

                if (grossPay >= 200)
                {
                    tax = grossPay * 20 / 100;
                }

                netPay = grossPay - tax;
            }// end calculatePay()
        }

        static void Main(string[] args)
        {
        }
    }
}
