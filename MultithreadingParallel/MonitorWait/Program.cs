using System;
using System.Threading;

namespace MonitorWait
{



    class Program
    {

        class MyThread
        {
            private string _name;

            public Thread thr;
            public MyThread(string name)
            {
                _name = name;

                thr = new Thread(ShowCase);
                thr.Start();
            }


        }

        static int number = 0;
        static object locker = new object();
        static void ShowCase()
        {
            while (number < 20)
            {
                lock (locker)
                {
                    if (number == 20)
                    {
                        break;
                    }

                    
                    number++;
                    Thread.Sleep(100);
                    Console.WriteLine($"[{Thread.CurrentThread.Name}],[{number}]");

                }
            }
        }

        static void Main()
        {
            Thread thr1 = new Thread(ShowCase);
            thr1.Name = "поток 1";
            thr1.Start();
            Thread thr2 = new Thread(ShowCase);
            thr2.Name = "поток 2";
            thr2.Start();

            Console.WriteLine("Main end");
            Console.ReadLine();
        }
    }
}
