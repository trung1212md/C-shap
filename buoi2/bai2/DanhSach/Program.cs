using System;
namespace prop
{
    class progam
    { 
        static void main(string[] agrs)
        {
            var ThanhPho=new List<string>();

                Console.WriteLine("nhap ten thanh pho");
            for(int i = 0; i < 5; i++)
            {
                ThanhPho.Add(Console.ReadLine());
            }
            ThanhPho.Sort();
            ThanhPho.Remove("Ha noi");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ThanhPho[i]);
            }
           

        }
    }
}