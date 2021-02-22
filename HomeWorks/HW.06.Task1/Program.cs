using System;

namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements add to the array:");
            int x = int.Parse(Console.ReadLine());
            int[] numRand = new int[x];
            int[] numUser = new int[x];
            int[] numResult = new int[x];
            Random rnd = new Random();
            for (int i = 0; i < numRand.Length; i++)
            {
                numRand[i] = rnd.Next(0, 9);
            }
            for (int i = 0; i < numUser.Length; i++)
            {
                Console.WriteLine("Enter  number:");
                int num = int.Parse(Console.ReadLine());
                numUser[i] = num;
            }
            for (int i = 0; i < numResult.Length; i++)
            {
                numResult[i] = numRand[i] + numUser[i];
            }
            Console.WriteLine();
            Console.WriteLine("Random array:");
            for (int i = 0; i < numRand.Length; i++)
            {
                Console.Write(numRand[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("User array:");
            for (int i = 0; i < numRand.Length; i++)
            {
                Console.Write(numUser[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum array");
            for (int i = 0; i < numRand.Length; i++)
            {
                Console.Write(numResult[i] + " ");
            }
        }
    }
}
