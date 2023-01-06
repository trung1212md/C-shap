using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap1
{
    public class Program
    {
        static List<Vang9999> vang9999s=new List<Vang9999>();
        static List<VangTrang> vangTrangs=new List<VangTrang>();
        static void Main(string[] args)
        {
            do
            {
                int n;
                Console.WriteLine("nhap lua chon()");
                n=int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        them();
                        break;
                    case 2:
                        sua(vang9999s, vangTrangs);
                        break;
                    case 3:
                        xoa(vang9999s, vangTrangs);
                        break;
                }

            }
            while (true);

        }

        public static void them()
        {
           VangTrang trang = new VangTrang();
            trang.nhap();
            vangTrangs.Add(trang);
           Vang9999 vang9999 = new Vang9999();
            vang9999.nhap();
            vang9999s.Add(vang9999);
        }
        public static void sua(List<Vang9999> vang9999s, List<VangTrang> vangTrangs)
        {
            for (int i = 0; i < vang9999s.Count; i++)
            {
                vang9999s[0].TenHang = "1";
                vang9999s[0].MaHang = "1";
                vang9999s[0].tuoivang = 1;

            }
            for (int i = 0; i < vangTrangs.Count; i++)
            {
                vangTrangs[0].TenHang = "1";
                vangTrangs[0].MaHang = "1";
                vangTrangs[0].trongluong = 1;

            }
        }
        public static void xoa(List<Vang9999> vang9999s, List<VangTrang> vangTrangs)
        {
            for(int i=0; i < vang9999s.Count; i++)
            {
                vang9999s.RemoveAt(i);
                

            }
            for (int i = 0; i < vangTrangs.Count; i++)
            {
                vangTrangs.RemoveAt(i);


            }
        }
    }
}
