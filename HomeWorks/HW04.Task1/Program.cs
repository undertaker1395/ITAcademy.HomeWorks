using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number:");
            string num1Txt = Console.ReadLine();
            while(Program.NumCheck(num1Txt) == false)
            {
                Console.WriteLine("ERROR!!! You entered not a number! Enter the 1st number again:");
                num1Txt = Console.ReadLine();
            }
            int num1 = Convert.ToInt32(num1Txt);

            Console.WriteLine("Enter the 2nd number:");
            string num2Txt = Console.ReadLine();
            while (Program.NumCheck(num2Txt) == false)
            {
                Console.WriteLine("ERROR!!! You entered not a number! Enter the 2nd number again:");
                num2Txt = Console.ReadLine();
            }
            int num2 = Convert.ToInt32(num2Txt);

            Console.WriteLine("Result of add: " + Program.Add(num1, num2));
        }

        static bool NumCheck(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!char.IsDigit(s[i])) return false;
            return true;
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
