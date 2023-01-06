using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap3
{
    public class Nhanvien
    {

        public string name { get; set; }
        public string type { get; set; }
        public string date { get; set; }

        public double price { get; set; }
        public double roseMoney = 0;
        private string datetime;

        public Nhanvien()
        {

        }

        public Nhanvien(string name, string type, string date, double price, double roseMoney)
        {
            this.name = name;
            this.type = type;
            this.date = date;
            this.price = price;
            this.roseMoney = roseMoney;
        }

        public Nhanvien(string name, string type, string datetime, double price)
        {
            this.name = name;
            this.type = type;
            this.date = datetime;
            this.price = price;
        }

        public string totring()
        {
            return $"Name:{name,20}Date:{date,20}Type:{type,20}price:{price,20}roseMoney:{roseMoney,20}";
        }
    }
}
