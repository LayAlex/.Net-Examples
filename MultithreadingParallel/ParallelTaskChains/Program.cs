using System;
using System.Threading.Tasks;

namespace ParallelTaskChains
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task1 = new Task<int>(() => Sum(4, 5));

            // задача продолжения
            Task task2 = task1.ContinueWith(sum => Display(sum.Result));

            task1.Start();

            // ждем окончания второй задачи
            task2.Wait();
            Console.WriteLine("End of Main");
            Console.ReadLine();
        }

        static int Sum(int a, int b) => a + b;
        static void Display(int sum)
        {
            Console.WriteLine($"Sum: {sum}");
        }

    }
}
