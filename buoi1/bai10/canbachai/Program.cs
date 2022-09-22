using System;

namespace CanBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            float epsilon;
            float result = 1.0f;
            Console.Write("Nhap a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap epsilon: ");
            epsilon = Convert.ToSingle(Console.ReadLine());
            while (Math.Abs((result * result - a) / a) >= epsilon)
            {
                result = (a / result - result) / 2 + result;
            }
            Console.WriteLine("Can bac hai cua a la: " + result);
        }
    }
}