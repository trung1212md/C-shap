
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baiso5
{
    internal class Program
    {

        static List<Nhanvienthoivu> nhanvienthoivus = new List<Nhanvienthoivu>();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            do
            {
                Console.WriteLine($"---------------Menu----------");
                Console.WriteLine($"1.Nhap thong tin");
                Console.WriteLine($"2.Hien thi thong tin");
                Console.WriteLine($"3.Sort");
                Console.WriteLine($"4.thoat");
                Console.WriteLine("nhap lua chon ");

                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {

                    case 1:
                        Nhap();
                        break;
                    case 2:
                        Hienthi();
                        break;
                    case 3:
                        Sort();
                        break;
                }

            }
            while (true);

           

        }
        public static void Nhap()
        
        {
            Console.WriteLine("1.nhap thong tin nhan vien");
            Console.WriteLine("2.nhap thong tin nhan vien thoi vu");
            int a=Convert.ToInt32(Console.ReadLine());
            if(a==1)
            {
                Console.WriteLine("nhap ho ten ");
                string hoten=Console.ReadLine();
               
                Console.WriteLine("nhap ngay thang nam");
                DateTime ngaytuyendung=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("nhap gio tinh nam/nu");
                string gioi = Console.ReadLine();

                bool gioitinh = (gioi == "nam") ? true : false;

                Nhanvienthoivu nhanvienthoivus1 = new Nhanvienthoivu();

                nhanvienthoivus.Add(nhanvienthoivus1);

            }
            else if(a==2)
            {
                Console.WriteLine("nhap ho ten ");
                string hoten = Console.ReadLine();

                Console.WriteLine("nhap ngay thang nam");
                DateTime ngaytuyendung = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("nhap so ngay lam");
                    int sosongaylamviec=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap gio tinh nam/nu");

                string gioi = Console.ReadLine();

                bool gioitinh = (gioi == "nam") ? true : false;

               

                Nhanvienthoivu nhanvienthoivus1 = new Nhanvienthoivu();

                nhanvienthoivus.Add(nhanvienthoivus1);
            }
            
        }
        public static void Hienthi()
        {
            Console.WriteLine($"{"ho ten",20}{"Gioi tinh",20}{"Ngay tuyen dung",20}{"So ngay lam viec",20}{"Tien luong",20}");
           foreach(var iteam in nhanvienthoivus)
            {
                string gioitinh = (iteam.gioitinh) ? "nam" : "nu";

                if(iteam.songaylamviec!=-1)
                {
                    Console.WriteLine($"{iteam.Hoten,20}{iteam.gioitinh,20}{iteam.Ngaytuyendung,20}{iteam.songaylamviec,20}{iteam.tinhtien(),20}");
                }
                else
                {
                    Console.WriteLine($"{iteam.Hoten,20}{iteam.gioitinh,20}{iteam.Ngaytuyendung,20}");
                }    
            }

        }
        public static void Sort()
        {
            for(int i = 0; i < nhanvienthoivus.Count; i++)
            {
                for(var j = i+1; j < nhanvienthoivus.Count; j++)
                {
                    if (DateTime.Compare(nhanvienthoivus[i].Ngaytuyendung, nhanvienthoivus[j].Ngaytuyendung)>=0)
                    {
                        Nhanvienthoivu tam = nhanvienthoivus[i];
                        nhanvienthoivus[i] = nhanvienthoivus[j];
                        nhanvienthoivus[j] = tam;
                    }
                    else if(DateTime.Compare(nhanvienthoivus[i].Ngaytuyendung, nhanvienthoivus[j].Ngaytuyendung) == 0)
                    {
                        if (string.Compare(nhanvienthoivus[i].Hoten, nhanvienthoivus[j].Hoten) <0)
                        {
                            Nhanvienthoivu tam = nhanvienthoivus[i];
                            nhanvienthoivus[i] = nhanvienthoivus[j];
                            nhanvienthoivus[j] = tam;
                        }
                    }
                }
            }
        }
    }
}
