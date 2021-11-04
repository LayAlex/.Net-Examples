using System;

namespace Recursion
{

    class Program
    {
        int fac_times(int n, int acc)
        {
            return (n == 0) ? acc : fac_times(n - 1, acc * n);
        }
        int factorial(int n)
        {
            return fac_times(n, 1);
        }

        static int Fact(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Fact(x - 1);
            }
        }

        static int IndirectMethod1(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            else
            {
                return IndirectMethod2(n - 1);
            }
        }

        static int IndirectMethod2(int n)
        {
            return IndirectMethod1(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IndirectMethod1(5));
        }
    }
}
