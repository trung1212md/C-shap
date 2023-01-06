using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class Program
    {
        static List<Congnhan> Congnhans = new List<Congnhan>();
        static List<Kisu> kisus = new List<Kisu>(); 
        static List <Nhanvien> nhanviens = new List<Nhanvien>();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            do
            {
                Console.WriteLine("|----------------Menu-----------------------------");
                Console.WriteLine($"|Chon 1.Nhap thong tin moi theo loai can bo:");
                Console.WriteLine($"|Chon 2.Tim kiem theo ma can bo:");
                Console.WriteLine($"|Chon 3.Tim kiem va xoa theo ma can bo:");
                Console.WriteLine($"|Chon 4.Hien thi thong tin ve danh sach cac can bo:");
                Console.WriteLine($"|Chon X.thoat truong trinh:");
                Console.WriteLine("|----------------End-----------------------------");
                Console.WriteLine("nhap lua chon:");
                n=Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        nhap();
                        break;
                    case 2:
                        timkiem("MACB", nhanviens, Congnhans, kisus);
                        break;
                    case 3:
                        timkiemxoa("MACB", nhanviens, Congnhans, kisus);
                        break;
                    case 4:
                        hienthicanbo(1999, nhanviens, Congnhans, kisus);
                        break;
                }

            }
            while (true);
           

        }
        public static void nhap()
        {
            Console.WriteLine("|----------------Menu-----------------------------");
            Console.WriteLine("1.nhap thong tin Cong nhan:");
            Console.WriteLine("2.nhap thong tin Ky su:");
            Console.WriteLine("3.nhap thong tin Nhan vien:");
            Console.WriteLine("|----------------End-----------------------------");
            int n;
            Console.WriteLine("nhap lua chon:");
            n = Convert.ToInt32(Console.ReadLine());
            if(n==1)
            {
                Congnhan congnhan = new Congnhan();
                congnhan.nhap();
                Congnhans.Add(congnhan);
            }
            if(n==2)
            {
                Kisu kisu = new Kisu();
                kisu.nhap();
                kisus.Add(kisu);
            }
            if(n==3)
            {
                Nhanvien nhanvien = new Nhanvien();
                nhanvien.nhap();
                nhanviens.Add(nhanvien);
            }
        }
        public static void timkiem(string MACB,List<Nhanvien>nhanviens,List<Congnhan>congnhans,List<Kisu>kisus)
        {
            for(int i=0;i<nhanviens.Count;i++)
            {
                if (MACB.CompareTo(nhanviens[i].MACB)==0)
                {
                    nhanviens[i].xuat();
                }
                else
                {
                    Console.WriteLine("ma Nhan vien ko co");
                }
            }
            


            for (int i = 0; i < congnhans.Count; i++)
            {
                if (MACB.CompareTo(congnhans[i].MACB) == 0)
                {
                    congnhans[i].xuat();
                }
                else
                {
                    Console.WriteLine("ma cong nhan ko co");
                }
            }
            for (int i = 0; i < kisus.Count; i++)
            {
                if (MACB.CompareTo(kisus[i].MACB) == 0)
                {
                    kisus[i].xuat();
                }
                else
                {
                    Console.WriteLine("ma ky su ko co");
                }
            }

        }
        public static void timkiemxoa(string MACB,List<Nhanvien>nhanviens,List<Congnhan>congnhans,List<Kisu>kisus)

        {
            for (int i=0;i<nhanviens.Count;i++)
            {
                if (MACB.CompareTo(nhanviens[i].MACB)==0)
                {
                    nhanviens.RemoveAt(i);
                    nhanviens[i].xuat();
                }
            }

           

            for (int i = 0; i < congnhans.Count; i++)
            {

                if (MACB.CompareTo(Congnhans[i].MACB) == 0)
                {
                    congnhans.RemoveAt(i);
                    congnhans[i].xuat();
                }
            }
             for (int i=0;i<kisus.Count;i++)
            {
                if (MACB.CompareTo(kisus[i].MACB) == 0)
                {
                    kisus.RemoveAt(i);
                    kisus[i].xuat();
                }
            }
            
        }
        public static void hienthicanbo(int namsinh, List<Nhanvien> nhanviens, List<Congnhan> congnhans, List<Kisu> kisus)
        {
            Console.WriteLine("|----------------Menu-----------------------------");
            Console.WriteLine("1.hien thi thong tin can bo xep loai theo loiacan bo,nam sinh:");
            Console.WriteLine("2.Hien nthi thong tin sap xep theo loai can bo,gioi tinh:");
            Console.WriteLine("|----------------End-----------------------------");
            int n;
            Console.WriteLine("Nhap lua chon:");
            n = Convert.ToInt32(Console.ReadLine());

            if(n==1)
            {
                Console.WriteLine("thong tin Nhan vien");
                nhanviens.Sort(delegate (Nhanvien a, Nhanvien b)
                {
                    return a.namsinh.ToString().CompareTo(b.namsinh.ToString());
                });

                foreach(var item in nhanviens)
                {
                    item.xuat();
                }

                Console.WriteLine("thong tin Cong nhan");
                congnhans.Sort(delegate(Congnhan a, Congnhan b)
                {
                    return a.namsinh.ToString().CompareTo(b.namsinh.ToString());
                });

                foreach (var item in Congnhans)
                {
                    item.xuat();
                }

                Console.WriteLine("thong tin Ky su");
                kisus.Sort(delegate (Kisu a, Kisu b)
                {
                    return a.namsinh.ToString().CompareTo(b.namsinh.ToString());
                });

                foreach (var item in kisus)
                {
                    item.xuat();
                }
            }
            if(n==2)
            {
                Console.WriteLine("Thong tin cong nhan la: ");
                congnhans.Sort(delegate (Congnhan a, Congnhan b)
                {
                    return a.gioitinh.CompareTo(b.gioitinh);
                });
                foreach (Congnhan i in congnhans)
                {
                    i.xuat();
                }

                Console.WriteLine("Thong tin ky su la: ");
                kisus.Sort(delegate (Kisu a, Kisu b)
                {
                    return a.gioitinh.CompareTo(b.gioitinh);
                });
                foreach (Kisu i in kisus)
                {
                    i.xuat();
                }

                Console.WriteLine("Thong tin cong nhan la: ");
                nhanviens.Sort(delegate (Nhanvien a, Nhanvien b)
                {
                    return a.gioitinh.CompareTo(b.gioitinh);
                });
                foreach (Nhanvien i in nhanviens)
                {
                    i.xuat();
                }
            }

        }
    }
}
