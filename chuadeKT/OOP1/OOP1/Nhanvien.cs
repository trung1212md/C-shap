using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class NhanVien : Tinhluong
    {
        public string MaNV { get; set; }
        public string ChucVu { get; set; }

        public override float Getluong()
        {
            float pc = 0f;
            if (ChucVu == "Giam doc")
            {
                pc = 0.5f;
            }
            else if (ChucVu == "Truong phong" || ChucVu == "Pho giam doc")
            {
                pc = 0.4f;
            }
            else if (ChucVu == "Pho phong")
            {
                pc = 0.3f;
            }
            return (HeSoLuong + pc) * luongcoban;
        }

        
    }
}
