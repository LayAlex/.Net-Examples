using System;
using System.Threading.Tasks;

namespace ParallelTaskWithParam
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task1 = new Task<int>(() => Factorial(8));
            task1.Start();

            Console.WriteLine($"Факториал числа 8 :  {task1.Result}");

            Task<string> task2 = new Task<string>(() =>
            {
                return "Hello world";
            });
            task2.Start();

            var b = task2.Result;  // ожидаем получение результата
            Console.WriteLine(b);

            Console.WriteLine($"Main завершен");
        }

        static int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}
