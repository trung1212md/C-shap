using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Program
    {
        static List<Nhanvien> list = new List<Nhanvien>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding= Encoding.UTF8;
            int n;
            do
            {
                Console.WriteLine($"----------------------Menu------------------------");
                Console.WriteLine($"1.Them");
                Console.WriteLine($"2. Hien thi danh sach");
                Console.WriteLine($"3. Sap xep");
                Console.WriteLine("4. Thoat");

                n = Convert.ToInt32(Console.ReadLine());

                switch(n)
                {
                    case 1:
                        them();
                        break;
                    case 2:
                        hienthidanhsach();
                        break;
                    case 3:
                        sort();
                        break;
                    case 4:
                        Console.WriteLine("thoat ");
                        break;
                    default:
                        Console.WriteLine("ko co chuc nang nay");
                        break;
                }
            }
            while (true);
        }

        public static void them()
        {
            Nhanvien nv = new Nhanvien();
            nv.nhap();

            foreach (var item in list)
            {
                if (item.MaNV == nv.MaNV)
                {
                    Console.WriteLine($"\nMã nhân viên trùng\n");
                    return;
                }
            }
            list.Add(nv);
        }
        public static void hienthidanhsach()
        {
            Console.WriteLine($"{"Ho Ten",20 }{"Dia Chi",20}{"Ma nhan vien",20}{"Chuc VU",20}{"Luong co ban",20}{"he so ",20}");
            foreach(var item in list)
            {
                Console.WriteLine($"{item.Hoten,20}{item.Diachi,20}{item.MaNV,20}{item.Chucvu,20}{item.luongcoban,20}{item.tinhheso(),20}");
            }
        }

        public static void sort()
        {

            for(int i = 0; i < list.Count-1; i++)
            {
                for(var j = i+1; j < list.Count; j++)
                {
                    if(list[i].tinhheso()> list[j].tinhheso())
                    {
                        Nhanvien tam = list[i];
                        list[i] = list[j];
                        list[j] = tam;
                    }
                    else if(list[i].tinhheso()== list[j].tinhheso())
                    {
                        if (list[i].luongcoban>list[j].luongcoban)
                        {
                        Nhanvien tam1=list[i];
                            list[i]=list[j];
                            list[j]=tam1 ;

                        }

                    }

                }
            }
        }
    }
}
