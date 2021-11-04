using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTaskParent
{
    class Program
    {
        static void Main(string[] args)
        {
            var outer = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Первая задача стартовала");
                var inner = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Вторая задача стартовала");
                    Thread.Sleep(2000);
                    Console.WriteLine("Вторая задача завершена");
                }, TaskCreationOptions.AttachedToParent);
            });
            outer.Wait();

            Console.WriteLine("Main завершился");

            Console.ReadLine();
        }
    }
}
