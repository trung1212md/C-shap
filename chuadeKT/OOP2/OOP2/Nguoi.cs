using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Nguoi
    {
        public string Hoten { get; set; }
        public string Diachi { get; set; }

        public virtual void nhap()
        {
            Console.WriteLine("nhap ho ten");
            Hoten=Console.ReadLine();
            Console.WriteLine("Nhap dia chi");
            Diachi=Console.ReadLine();
        }

    }
}
