using System;

namespace HW07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter poem. Use \";\" to split strings:");
            string poemO = Console.ReadLine();
            string poemA = poemO.Replace('O', 'A');
            string[] poemSplit = poemA.Split(';');
            foreach (string newStrPoem in poemSplit)
            {
                Console.WriteLine(newStrPoem);
            }
        }
    }
}
