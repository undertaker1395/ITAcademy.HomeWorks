using System;
using System.Diagnostics;

namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements add to the array:");
            int x = int.Parse(Console.ReadLine());
            long[] numRand = new long[x];

            long temp;
            Random rnd = new Random();
            for (int i = 0; i < numRand.Length; i++)
            {
                numRand[i] = rnd.Next(-9, 9);
            }
            Console.WriteLine();
            Console.WriteLine("Random array:");
            for (int i = 0; i < numRand.Length; i++)
            {
                Console.Write(numRand[i] + " ");
            }
            Console.WriteLine();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < numRand.Length; i++, x--)
            {
                if (i > x - 1 || i == x - 1) break;
                temp = numRand[i];
                numRand[i] = numRand[x - 1];
                numRand[x - 1] = temp;
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine();
            Console.WriteLine("Reversed array:");
            for (int i = 0; i < numRand.Length; i++)
            {
                Console.Write(numRand[i] + " ");
            }
            Console.WriteLine();
            stopWatch.Start();
            Array.Reverse(numRand);
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine();
            Console.WriteLine("Reversed back array:");
            for (int i = 0; i < numRand.Length; i++)
            {
                Console.Write(numRand[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("My RunTime " + elapsedTime);
            Console.WriteLine("ArrayF RunTime " + elapsedTime1);
        }
    }
}
