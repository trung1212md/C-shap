﻿namespace bai1
{
    internal static class ProgramHelpers
    {
        public static int t(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 && n == 2)
            {
                return 1;
            }
            else if (n >= 3)
            {
                return t(n - 1) + t(n - 2);
            }
        }
    }
}