using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class UCNL
    {
        public int sothu1 { get; set; }
        public int sothu2 { get; set; } 
        public int UCLN
        {
            get
            {
                if(sothu1 >sothu2)
                {
                    int tem = sothu1;
                    sothu1 = sothu2;
                    sothu2 = tem;
                }
                while(sothu1*sothu2!=0)
                {
                    if(sothu1>sothu2)
                    {
                        sothu1 %= sothu2;

                    }
                    else
                    {
                        sothu2 %= sothu1;
                    }
                }
                return sothu1+sothu2;
            }
        }
        public void input()
        {
            Console.Write("Nhap so thu 1: ");
            sothu1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu 2: ");
            sothu2 = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("UCLN la: " + UCLN);
        }

    }
}
