using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luyentap5
{
    internal class Program
    {

        class TestOverride
        {
            public class Employee 
            {
                 public string name;
                // thuộc tính basepay is được định nghĩa là được bảo vệ
                // vì vậy nó chỉ có thể truy  cập bởi class này và các class dẫn khác
                protected decimal basepay;
                    // phuong thuc khoi tao thiet lap gia tri name va basepay cho employee
                   public Employee(string name, decimal basepay)
                {
                        this.name = name;
                        this.basepay = basepay;

                }

                //khai bao la virtual,do do phuong thuc nay duoc ghi de
                 public virtual decimal CalculatePay()
                {
                    return basepay;
                }
            }

            // tao ra 1 class moi ke thua tu class employee
            public class SalesEmployee:Employee
            {
                private decimal salesbonus;
                // tao phuong thuc khoi tao cua base-class
                // gan gia tri cho bien salesbonus
                public SalesEmployee(string name,decimal basepay,decimal salesbonus):base(name,basepay)
                { 
                        this.salesbonus = salesbonus;
                       
                }

                // ghi de phuong thuc CalculatePay

                public override decimal CalculatePay()
                {
                    return basepay + salesbonus;
                }

            }

            static void Main(string[] args)
        {
                var employee1 = new SalesEmployee("Alice", 1000, 500);
                var employee2 = new Employee("Bob", 1200);

                // Moi class se goi phuong thuc calculatePay cua rieng minh.
                Console.WriteLine("Employee 1: " + employee1.name + ", earned: " +
employee1.CalculatePay());
                Console.WriteLine("Employee 2: " + employee2.name + ", earned: " +
               employee2.CalculatePay());
            }
    }
}
