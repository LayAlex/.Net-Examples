using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTasks
{

    class Program
    {

        static void TaskExample(string text, int timeSec)
        {
            Thread.Sleep(timeSec * 1000);
            Console.WriteLine("text");
        }

        static void Main(string[] args)
        {
            var task1 = new Task(() => TaskExample("[1] Task.Start() завершено 1", 20));
            task1.Start();

            var task2 = Task.Factory.StartNew(() => TaskExample("[2] Task.Factory завершено", 30));

            var task3 = Task.Run(() => TaskExample("[3] Task.Run завершено", 40));

            Task.WaitAll(task1, task2, task3); // Если закомментировать то Main будет завершен раньше чем задачи
            Console.WriteLine("Main завершен");

            Console.ReadKey();
        }
    }
}
