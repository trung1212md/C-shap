using System;
namespace phieu1
{
    class Program
    {
        static void Main(string[] agrs)
        {
            string s;
            Console.Write("a) Nhap chuoi: ");
            s = Convert.ToString(Console.ReadLine());
            foreach (char i in s)
            {
                Console.WriteLine(i);
            }
            Console.Write("b) Nhap chuoi: ");
            s = Convert.ToString(Console.ReadLine());
            s = s.Trim();
            for(int i = 0; i < s.Length-1; i++)
            {
                if (s[i]==' ' && s[i+1] !=' ')
                {
                    Console.WriteLine(s[i]);

                }
                else if(s[i]==' ' && s[i+1] !=' ')
                {
                    Console.WriteLine(s[i]);
                }
            }
            Console.WriteLine(s[s.Length-1]);

            Console.WriteLine(s[s.Length - 1]);
            Console.Write("c) Nhap chuoi: ");
            s = Convert.ToString(Console.ReadLine());
            var demso = new Dictionary<char, int>();
            foreach (char i in s)
            {
                if (demso.ContainsKey(i) == false)
                {
                    demso.Add(i, 1);
                }
                else
                {
                    demso[i]++;
                }
            }
            Console.WriteLine("Liet ke so lan xuat hien cua cac ky tu");
            foreach (char i in demso.Keys)
            {
                Console.WriteLine(i + " xuat hien " + demso[i]);
            }
        }
    }
}