using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<ThiSinhA> listThiSinh = new List<ThiSinhA>();
            int n;
            do
            {
                Console.WriteLine("============== Danh sach cac lua chon ================");
                Console.WriteLine("|   1. Nhap thong tin 1 thi sinh                     |");
                Console.WriteLine("|   2. Hien thi danh sach cac thi sinh               |");
                Console.WriteLine("|   3. Hien thi cac sinh vien theo tong diem         |");
                Console.WriteLine("|   4. Hien thi cac sinh vien theo dia chi           |");
                Console.WriteLine("|   5. Tim kiem theo so bao danh                     |");
                Console.WriteLine("|   6. Ket thuc                                      |");
                Console.WriteLine("======================================================");

                Console.WriteLine("nhap lua chon cua ban");
                n=Convert.ToInt32(Console.ReadLine());

                switch(n)
                {
                    case 1:
                        nhap(listThiSinh);
                        break;
                    case 2:
                        xuat(listThiSinh);
                        break;
                    case 3:
                        float t;
                        Console.WriteLine("nhap tong diem");
                        t=Convert.ToSingle(Console.ReadLine());
                        Hienthitongdiem(listThiSinh,t);
                        break;
                    case 4:
                        string a;
                        Console.WriteLine("nhap dia chi");
                        a = Console.ReadLine();
                        hienthidiachi(listThiSinh,a);
                        break;
                    case 5:
                        string b;
                        Console.WriteLine("nhap so bao danh");
                        b = Console.ReadLine();
                        timkiemsbd(listThiSinh,b);
                        break;

                }
            }while(true);


         
        }
        // nhap thi sinh
        public static void nhap(List<ThiSinhA> listThiSinh)
        {
           ThiSinhA thiSinhA= new ThiSinhA();
            Console.WriteLine("nhap so bao danh:");
            thiSinhA.Sbd = Console.ReadLine();
            Console.WriteLine("nhap ho ten:");
            thiSinhA.Hoten= Console.ReadLine();
            Console.WriteLine("nhap dia chi:");
            thiSinhA.Diachi= Console.ReadLine();
            Console.WriteLine("nhap diem toan:");
            thiSinhA.Toan=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap diem ly: ");
            thiSinhA.Ly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap diem hoa:");
            thiSinhA.Hoa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap diem uu tien:");
            thiSinhA.Diemuutien = Convert.ToInt32(Console.ReadLine());

            thiSinhA.Tongdiem = thiSinhA.Toan + thiSinhA.Ly + thiSinhA.Hoa + thiSinhA.Diemuutien;
            listThiSinh.Add(thiSinhA);
            

        }
        // xuat danh sach sinh viem
        static void xuat(List<ThiSinhA> thisinhs)
        {
            Console.WriteLine("SBD".PadRight(20) + "Ho Ten".PadRight(20) + "Dia Chi".PadRight(20) + "Toan ".PadRight(20) + "Ly".PadRight(20) +
                "Hoa".PadRight(20) + "Diem uu tien".PadRight(20) +"Tong diem".PadRight(20) );

            for(int i=0;i<thisinhs.Count;i++)
            {
                Console.WriteLine(thisinhs[i].Sbd.PadRight(20)+ thisinhs[i].Hoten.PadRight(20) + thisinhs[i].Diachi.PadRight(20) + Convert.ToString(thisinhs[i].Toan).PadRight(20) +
                    Convert.ToString(thisinhs[i].Ly).PadRight(20) + Convert.ToString(thisinhs[i].Hoa).PadRight(20) + Convert.ToString(thisinhs[i].Diemuutien).PadRight(20) + Convert.ToString(thisinhs[i].Tongdiem ).PadRight(20));

            }
        }
    // hien thi cac sinh vien theo tong diem
    static void Hienthitongdiem(List<ThiSinhA> thisinhb,float t)
        {
            thisinhb.Sort();
            Console.WriteLine("SBD".PadRight(20) + "Ho Ten".PadRight(20) + "Dia Chi".PadRight(20) + "Toan ".PadRight(20) + "Ly".PadRight(20) +
               "Hoa".PadRight(20) + "Diem uu tien".PadRight(20) + "Tong diem".PadRight(20));

            for(int i=0;i<thisinhb.Count;i++)
            {
                if (thisinhb[i].Tongdiem>t)
                {
                    Console.WriteLine(thisinhb[i].Sbd.PadRight(20) + thisinhb[i].Hoten.PadRight(20) + thisinhb[i].Diachi.PadRight(20) + Convert.ToString(thisinhb[i].Toan).PadRight(20)+

                            Convert.ToString(thisinhb[i].Ly).PadRight(20) + Convert.ToString(thisinhb[i].Hoa).PadRight(20) + Convert.ToString(thisinhb[i].Diemuutien).PadRight(20) + Convert.ToString(thisinhb[i].Tongdiem).PadRight(20));

                }
            }
            // hien thi cac sinh vien theo dia chi

        }
            static void hienthidiachi(List<ThiSinhA> thisinhc,string a)
            {
           
            Console.WriteLine("SBD".PadRight(20) + "Ho Ten".PadRight(20) + "Dia Chi".PadRight(20) + "Toan ".PadRight(20) + "Ly".PadRight(20) +
               "Hoa".PadRight(20) + "Diem uu tien".PadRight(20) + "Tong diem".PadRight(20));

            for (int i = 0; i < thisinhc.Count; i++)
            {
                if (thisinhc[i].Diachi.CompareTo(a)==0)
                {
                    Console.WriteLine("SBD".PadRight(20) + "Ho Ten".PadRight(20) + "Dia Chi".PadRight(20) + "Toan ".PadRight(20) + "Ly".PadRight(20) +
               "Hoa".PadRight(20) + "Diem uu tien".PadRight(20) + "Tong diem".PadRight(20));
                }
            }
        }

            static void timkiemsbd(List<ThiSinhA> thisinhd,string b)
        {
            Console.WriteLine("SBD".PadRight(20) + "Ho Ten".PadRight(20) + "Dia Chi".PadRight(20) + "Toan ".PadRight(20) + "Ly".PadRight(20) +
               "Hoa".PadRight(20) + "Diem uu tien".PadRight(20) + "Tong diem".PadRight(20));

            for(int i = 0; i < thisinhd.Count; i++)
            {
                if (thisinhd[i].Sbd.CompareTo(b)==0)
                {
                    Console.WriteLine("SBD".PadRight(20) + "Ho Ten".PadRight(20) + "Dia Chi".PadRight(20) + "Toan ".PadRight(20) + "Ly".PadRight(20) +
             "Hoa".PadRight(20) + "Diem uu tien".PadRight(20) + "Tong diem".PadRight(20));
                }
            
            }
        }
    }
}
