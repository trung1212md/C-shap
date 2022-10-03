using System;
namespace phieu2
{
    class Program {

        static void Main(string[] args) {

            int[] a;
            int n;
            Console.WriteLine("nhap n");
            n=Convert.ToInt32(Console.ReadLine());
            a=new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            int max =a[0];int  min = a[0];int tong = a[0];
            for(int i = 0; i < n; i++)
            {
                if (a[i]>max)
                    max = a[i];
                if(a[i]<min)
                    min = a[i];
                tong += a[i];
            }
            Console.WriteLine("so lon nhat trong mang la:" + max);
            Console.WriteLine("so lon nhat trong mang la:" + min);
            Console.WriteLine("so lon nhat trong mang la:" + tong);
        }
        
    
    
    
    }


}