using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danhsach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ThanhPho=new List<string>();

            Console.WriteLine("nhap thanh pho");
            for(int i = 0; i < 5; i++)
            {
                ThanhPho.Add(Console.ReadLine());
            }
            ThanhPho.Sort();
            ThanhPho.Remove("ha noi");
            for (int i = 0; i < 5; i++)
            {
                ThanhPho.Add(Console.ReadLine());
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(ThanhPho[i]);
            }
        }
    }
}
