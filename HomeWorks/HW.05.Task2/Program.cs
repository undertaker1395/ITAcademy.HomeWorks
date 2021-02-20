using System;

namespace HW._05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
        link1:
            Console.WriteLine("Enter the number above 0 and below 100:");
            string numTxt = Console.ReadLine();
            int num;
            while (Program.NumCheck(numTxt) == false)
            {
                Console.WriteLine("Enter the number above 0 and below 100:");
                numTxt = Console.ReadLine();
                num = Convert.ToInt32(numTxt);
            }
            num = Convert.ToInt32(numTxt);
            if (num >= 100) goto link1;
            int x = num;
            for (int i = 1; i <= num; i++)
            {
                int[] numPiramid = new int[x];
                x--;
                foreach (int n in numPiramid)
                {
                    Console.Write(i%10 + " ");
                }
                Console.WriteLine();
                for(int z = 1; z <= i; z++)
                {
                    Console.Write(" ");
                }
            }
        }
        static bool NumCheck(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!char.IsDigit(s[i])) return false;
            return true;
        }
    }
}
