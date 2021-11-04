using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(1, 10, Factorial);

            Console.ReadLine();

            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 },
                Factorial);

            Console.ReadLine();
        }

        static void Factorial(int x, ParallelLoopState pls)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
                if (i == 5)
                 pls.Break(); // Принудительно выходим из цикла .. факториал выше числа 5 не считаем!!
            }
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Console.WriteLine($"Факториал числа {x} равен {result}");
            Thread.Sleep(3000);
        }
    }
}
