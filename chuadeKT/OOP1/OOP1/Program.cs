using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static List<NhanVien> nhanviens = new List<NhanVien>();
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.InputEncoding=Encoding.UTF8;
            int n;
            do
            {
                Console.WriteLine("---------------------Menu------------------");
                Console.WriteLine("1.them ");
                Console.WriteLine("2.Hien thi danh sach ");
                Console.WriteLine("3.Sap xep ");
                Console.WriteLine("4.thoat ");
                Console.WriteLine("nhap lua chon");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        AddNhanVien();
                        break;
                    case 2:
                        show();
                        break;
                    case 3:
                        sort();
                        break;
                    case 4:
                        Console.WriteLine("thoat khoi chuong trinh");
                        break;
                    default:
                        Console.WriteLine($"Không có lựa chọn này");
                        break;


                }
            }
            while (true);
        }

        public static void AddNhanVien()
        {
           NhanVien nhanVien=new NhanVien();
            Console.WriteLine($"Nhap ten:");
            nhanVien.hoten = Console.ReadLine();
            Console.WriteLine($"nhap dia chi:");
            nhanVien.diachi = Console.ReadLine();
            Console.WriteLine($"nhap he so luong:");
            nhanVien.HeSoLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"nhap luong co ban:");
            nhanVien.luongcoban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Nhap Ma nhan vien:");
            nhanVien.MaNV = Console.ReadLine();
            Console.WriteLine($"Nhap Chuc vu:");
            nhanVien.ChucVu = Console.ReadLine();

            nhanviens.Add(nhanVien);
        }

        public static void show()
        {
            Title();
            foreach (var item in nhanviens)
            {
                Console.WriteLine($"{item.hoten,20} {item.diachi,20}{item.HeSoLuong,20}{item.luongcoban,20}{item.MaNV,20}{item.ChucVu,20}{ item.Getluong(),20}");
              
            }
        }
        public static void sort()
        {
            for(int i = 0; i < nhanviens.Count; i++)
            {
                for(int j=nhanviens.Count-1; j>=0; j--)
                {
                    if(nhanviens[i-1].Getluong()>nhanviens[j].Getluong())
                    {
                        NhanVien tam = nhanviens[i];
                        nhanviens[i]=nhanviens[j];
                        nhanviens[j] = tam;
                    }
                }
            }
        }
        public static void Title()
        {
            Console.WriteLine($"{"Họ tên",20} {"Địa chỉ",20} {"Hệ số lương",20} {"Lương cơ bản",20} {"Mã nhân viên",20} {"Chức vụ",20} {"Lương",20}");
        }
    }
}
