using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static int cnt = 0;

        static int? BinarySearch(List<int> arr, int element)
        {
            var len = arr.Count();
            var pos = len / 2;

            var start = 0;
            var finish = len - 1;

            while (start != finish)
            {
                cnt++;
                if (element == arr[pos])
                {
                    return pos;
                }

                if (pos > 0 && element == arr[pos - 1])
                {
                    return pos - 1;
                }

                if (pos < len - 1 && element == arr[pos + 1])
                {
                    return pos + 1;
                }

                if (element < arr[pos])
                {
                    finish = pos;
                }
                else
                {
                    start = pos;
                }

                if (((finish - start) / 2) == 0)
                {
                    break;
                }
                pos = ((finish - start) / 2) + start;
            }

            return null;
        }

        static int GetCountAlg()
        {
            Random rnd = new Random();

            var N = 10000;
            var arr = new List<int>();

            for (int i = 0; i < N; i++)
            {
                var r = i;
                arr.Add(r);
                // Console.Write($"{arr[i]} ,");
            }

          //  Console.WriteLine();
            var element = rnd.Next(0, N);

            cnt = 0;
            var result = BinarySearch(arr, element);

            //Console.WriteLine($"Элементов : {N}");
            //Console.WriteLine($"Ищем : {element}");
            //Console.WriteLine($"Проходов : {cnt}");
            //Console.WriteLine();
            //Console.WriteLine(result != null ? $"Найдено {arr[(int)result]}" : "ПУСТО");
            //

            return cnt;
        }



        static void Main(string[] args)
        {
            var N = 100;
            var summ = 0;
            for (int i = 0; i < N; i++)
            {
                summ += GetCountAlg();
          //      Console.Write($"{GetCountAlg()}, ");

            }

            var sred = summ / N;

            //Console.WriteLine($"Элементов : {N}");
            //Console.WriteLine($"Ищем : {element}");
            Console.WriteLine($"среднее число проходов : {sred}");

            Console.ReadKey();
        }
    }
}
