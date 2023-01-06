using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phieubai1
{
    internal class Program
    {
        class Person
        {
            public  string id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public string email { get; set; }
            public string address { get; set; }

            public Person()
            {
                id = "default";
                name= "default";
                age = 0;
                email = "default";
                address = "default";
            }
            public Person(string id, string name, int age, string email, string address)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.email = email;
                this.address = address;
            }
            public void CheckAge()
            {
                
                if (age>=18)
                {
                    Console.WriteLine("ban du tuoi bau cu");

                }
                else
                {
                    Console.WriteLine("ban con nho:");
                }
            }
            public void Input()
            {
                Console.WriteLine("id:");
                id= Console.ReadLine();
                Console.WriteLine("Name:");
                name= Console.ReadLine();
                Console.WriteLine("age");
                age=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("email:");
                email= Console.ReadLine();
                Console.WriteLine("address");
                address= Console.ReadLine();
            }

            public void Output()
            {
                Console.WriteLine("id:" + id);
                Console.WriteLine("name:" + name);
                Console.WriteLine("age:" + age);
                Console.WriteLine("email:" + email);
                Console.WriteLine("address:" + address);

            }
        }
        static void Main(string[] args)
        {
            Person em = new Person();
            em.Input();
            em.CheckAge();
            em.Output();


        }
    }
}
