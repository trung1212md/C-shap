using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo phanSo1 = new PhanSo(3, 2);
            PhanSo phanSo2 = new PhanSo();

            phanSo2.TuSo = 5;
            phanSo2.MauSo = 2;
            PhanSo phanSo3 = new PhanSo();
            phanSo3 = phanSo1.Cong(phanSo2);

        }



        class PhanSo
        {
            private int m_TuSo;
            private int m_MauSo;

            public int TuSo
            {
                get { return m_TuSo; }
                set { m_TuSo = value; }
            }
            public int MauSo
            {
                get { return m_MauSo; }
                set
                {
                    if (kiem_tra_mau_so(value))
                        m_MauSo = value;
                }
            }

            public PhanSo()
            {
                m_TuSo = 1;
                m_MauSo = 1;
            }
            public PhanSo(int tuSo, int mauSo)
            {
                this.m_TuSo = tuSo;
                if (kiem_tra_mau_so(mauSo))
                    this.m_MauSo = mauSo;
            }

            private bool kiem_tra_mau_so(int mauSo)
            {
                return mauSo != 0;
            }

            public PhanSo Cong(PhanSo phanSo)
            {
                PhanSo phanSoKetQua = new PhanSo();
                phanSoKetQua.TuSo = m_TuSo * phanSo.MauSo + m_MauSo * phanSo.TuSo;
                phanSoKetQua.MauSo = m_MauSo * phanSo.MauSo;
                return phanSoKetQua;
            }
            public static PhanSo operator +(PhanSo phanSo1, PhanSo phanSo2)
            {
                PhanSo phansoKetQua = new PhanSo();
                phansoKetQua.TuSo = phanSo1.TuSo * phanSo2.MauSo + phanSo2.TuSo * phanSo1.MauSo;
                phansoKetQua.MauSo = phanSo1.MauSo * phanSo2.MauSo;
                return phansoKetQua;
            }

        }
    }
}