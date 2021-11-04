using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(ShowDate, ShowTime); // выполняется параллельно

            Console.ReadLine();
        }

        static void ShowDate()
        {
            Thread.Sleep(2000);
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
        }

        static void ShowTime()
        {
            Thread.Sleep(2000);
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
