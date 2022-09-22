using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ten;
            Console.WriteLine("nhap ho va ten");
          string st=Console.ReadLine();
            ten=st;
            int diem;
            Console.WriteLine("nhap diem");
            st=Console.ReadLine();
            diem=int.Parse(st);

            if (diem >= 8)
            {
                Console.WriteLine("ho va ten {0} diem {1} xep loai gioi", ten.ToUpper(), diem);
            }
            else if(diem>=6.5&& diem < 8)
            {
                Console.WriteLine("ho va ten {0} diem {1} xep loai kha", ten.ToUpper(), diem);
            }
            else if(diem>=5 && diem < 6.5)
            {
                Console.WriteLine("ho va ten {0} diem {1} xep loai Trung binh", ten.ToUpper(), diem);
            }
            else
            {
                Console.WriteLine("ho va ten {0} diem {1} xep loai yeu", ten.ToUpper(), diem);
            }
        }
    }
}
