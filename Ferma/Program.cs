using System;
using System.Runtime.CompilerServices;

namespace Fermap
{
    class Program
    {
        public static bool CheckFermat(int a, int b, int c, int n)
        {
            if (n <= 2)
            {
                throw new ArgumentException("n должно быть больше 2.");
            }
            return Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n);
        }
    }
}