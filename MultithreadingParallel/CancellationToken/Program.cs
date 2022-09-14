using System;
using System.Threading;
using System.Threading.Tasks;

namespace CancellationTokenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            var task1 = new Task(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write(".");
                }

                Console.WriteLine("Task finished");
            }
            );
            task1.Start();

            Thread.Sleep(4000);
            cancellationTokenSource.Cancel();

            Console.ReadKey();
        }
    }
}
