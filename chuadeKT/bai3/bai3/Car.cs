using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class Car:Vehicle
    {
        public  string bienso { get; set; }
        public  string dongxe { get; set; }

        public  string phienban { get; set; }

        public  int giacoban { get; set; }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap thong tin bien so xe");
            bienso = Console.ReadLine();
            Console.WriteLine("nhap thong tin dong xe");
            dongxe = Console.ReadLine();
            Console.WriteLine("nhap phien ban ");
            phienban = Console.ReadLine();
            Console.WriteLine("nhap gia co ban");
            giacoban = Convert.ToInt32(Console.ReadLine());
        }
        public int giaxe()
        {
            int giaT = 0;
            if(phienban=="Standard")
            {
                giaT = 0;
            }
            else if(phienban=="Premium")
            {
                giaT = 2000;
            }
            else if(phienban=="Deluxe")
            {
                giaT = 5000;
            }
            else if(phienban=="Luxury")
            {
                giaT = 10000;
            }

            return (giacoban + giaT);
        }
    }
}
