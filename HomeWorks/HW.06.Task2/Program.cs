using System;

namespace HW._06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements add to the array:");
            int x = int.Parse(Console.ReadLine());
            int[] userArr = new int[x];
            for (int i = 0; i < userArr.Length - 1; i++)
            {
                Console.WriteLine("Enter  number:");
                int num = int.Parse(Console.ReadLine());
                userArr[i] = num;
            }
            Console.WriteLine();
            Console.WriteLine("User array:");
            for (int i = 0; i < userArr.Length; i++)
            {
                Console.Write(userArr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Add one more element to the array.");
            Console.WriteLine("Enter number:");
            int newNum = int.Parse(Console.ReadLine());
        link1:
            Console.WriteLine("Enter the position from 0 to " + (x - 1) + ":");
            int pos = int.Parse(Console.ReadLine());
            if (pos >= x || pos < 0) goto link1;
            for (int i = userArr.Length - 1; i > 0; i--)
            {
                if (i > pos)
                {
                    userArr[i] = userArr[i - 1];
                }
                if (i == pos)
                {
                    userArr[i] = newNum;
                }
            }
            Console.WriteLine("New user array:");
            for (int i = 0; i < userArr.Length; i++)
            {
                Console.Write(userArr[i] + " ");
            }

        }
    }
}
