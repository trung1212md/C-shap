using System;

namespace PhuongThuc
{
    internal class ProgramBase
    {

        public static bool TestNT(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static bool testNT(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
                else
                    return true;
            }
        }
    }
}