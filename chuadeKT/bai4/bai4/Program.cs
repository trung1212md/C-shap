using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {   

        static List<NhanvienBH> NhanvienBHs=new List<NhanvienBH>();
          static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding=Encoding.UTF8;
            int n;

            do
            {
                Console.WriteLine($"---------------Menu----------");
                Console.WriteLine($"1.Nhap thong Tin");
                Console.WriteLine($"2.hien thi thong tin");
                Console.WriteLine($"3.sap xep");
                Console.WriteLine($"4.thoat");
                Console.WriteLine("nhap lua chon");
                n = Convert.ToInt32(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        nhap();
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
                }
            }
            while (true);

           

        }

        public static void nhap()
        {
            Console.WriteLine("1.nhap thong tin nhan vien");
            Console.WriteLine("2.nhap thong tin nhan vien ban hang");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a==1)
            {
                Console.WriteLine("nhap ho ten");
                string hoten=Console.ReadLine();
                Console.WriteLine("Nhap ngay tuyen dung ngay thang nam");
                DateTime NgayTD = DateTime.Parse(Console.ReadLine());

                

                NhanvienBH n=new NhanvienBH(hoten,NgayTD,-1);

                
                NhanvienBHs.Add(n);
                
            }
            else if (a == 2)
            {
                Console.WriteLine("nhap ho ten");
                string hoten = Console.ReadLine();
                Console.WriteLine("Nhap ngay tuyen dung ngay thang nam");
                DateTime NgayTD = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("nhap so luong ban");
                int solg = int.Parse(Console.ReadLine());

                NhanvienBH n = new NhanvienBH(hoten, NgayTD, solg);


                NhanvienBHs.Add(n);

            }
            else
            {
                Console.WriteLine("khong co lua chon nay");
            }

        }
        public static void Hienthi()
        {

            Console.WriteLine($"{"Ho ten",20}{"Ngay tuyen dung",20}{"so luong",20}{"Tien hoa hong",20}");
            foreach(var item in NhanvienBHs)
            {
                if (item.solg != -1)
                    Console.WriteLine($"{item.hoten,20}{item.NgayTD,20}{item.solg,20}{item.tinhtienhoahong(),20}");
                else
                    Console.WriteLine($"{item.hoten,20}{item.NgayTD,20}");
            }

        }
        public static void sapxep()
        {
            for (int i = 0; i < NhanvienBHs.Count; i++)
            {
                for(int j = i+1; j < NhanvienBHs.Count;j++)
                {
                    if (DateTime.Compare(NhanvienBHs[i].NgayTD, NhanvienBHs[j].NgayTD)>0)
                    {
                        NhanvienBH n = NhanvienBHs[i];
                        NhanvienBHs[i]=NhanvienBHs[j];
                        NhanvienBHs[j] = n;

                    }
                    else if(DateTime.Compare(NhanvienBHs[i].NgayTD, NhanvienBHs[j].NgayTD) ==0)    
                    {
                        if (string.Compare(NhanvienBHs[i].hoten, NhanvienBHs[j].hoten)>0)
                        {
                            NhanvienBH n = NhanvienBHs[i];
                            NhanvienBHs[i] = NhanvienBHs[j];
                            NhanvienBHs[j] = n;
                        }

                    }
                }
            }
        }
    }
}
