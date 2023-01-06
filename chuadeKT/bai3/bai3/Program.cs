using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {

        static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
        Console.InputEncoding=Encoding.UTF8;
        Console.OutputEncoding=Encoding.UTF8;

            int n;
            do
            {
                Console.WriteLine($"---------------Menu------------------");
                Console.WriteLine($"1.Them");
                Console.WriteLine($"2.Hien thi danh sach");
                Console.WriteLine($"3.sap xep");
                Console.WriteLine($"4.thoat");
                Console.WriteLine("nhap lua chon");
                n = int.Parse(Console.ReadLine());


                switch (n)
                {
                    case 1:
                        Them();
                       break;
                    case 2:
                        Hienthi();
                        break;
                    case 3:
                        sapxep();
                        break;
                    case 4:
                        Console.WriteLine("thoat");
                        break;
                    default:
                        Console.WriteLine("ko co lua chon nay");
                        break;
                }

            }
            while (n!=4);

        }
        public static void Them()
        {
            Car car1 = new Car();
            car1.nhap();
           cars.Add(car1);
            foreach(var item in cars)
            {
                if(item.bienso==car1.bienso)
                {
                    Console.WriteLine("ko duoc trung bien so xe");
                    return;
                }
            }
        }
        public static void Hienthi()
        {
            Console.WriteLine($"{"Hang SX",20}{"Mau sac",20}{"Bien so xe",20}{"Dong xe",20}{"Phien ban",20}{"Gia co ban",20}{"gia xe",20}");

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.HangSX,20}{item.Mausac,20}{item.bienso,20}{item.dongxe,20}{item.phienban,20}{item.giacoban,20}{item.giaxe(),20}");
            }
        }
       
        public static void sapxep()
        {
            for (int i = 0; i < cars.Count-1; i++)
            {
                for(int j = i+1; j < cars.Count; j++)
                {
                    if (cars[i].giaxe() > cars[j].giaxe())
                    {
                        Car tam = cars[i];
                        cars[i] = cars[j];
                        cars[j] = tam;

                    }
                }
            }
        }
    }
}
