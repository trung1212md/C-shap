using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap2
{
    public class Nhanvien
    {
        private string datetime;

        public string name { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public double price { get; set; }

        public double roseMoney { get; set; }

        public Nhanvien()
        {

        }

        public Nhanvien(string name, string type, string date, double price)
        {
            this.name = name;
            this.type = type;
            this.date = date;
            this.price = price;
            
            if (price < 1000) roseMoney = 0;
            else if (price >= 1000 && price <= 5000) roseMoney = 0.05 * price;
            else roseMoney = 0.1 * price;
        }

   

        public string toString()
        {
            return $"Name:{name,10} type:{name,10}date:{name,10} price:{name,10}roseMoney:{name,10}";
        }
    }
}
