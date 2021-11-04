using System;
using System.Threading.Tasks;

namespace ParallelTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Task(() => Console.WriteLine("[1] Task.Start() завершено 1"));
            task1.Start();

            var rt = task1.AsyncState;

            var task2 = Task.Factory.StartNew(() => Console.WriteLine("[2] Task.Factory завершено"));

            var task3 = Task.Run(() => Console.WriteLine("[3] Task.Run завершено"));

            Task.WaitAll(task1, task2, task3); // Если закомментировать то Main будет завершен раньше чем задачи
            Console.WriteLine("Main завершен");

            Console.ReadKey();
        }
    }
}
