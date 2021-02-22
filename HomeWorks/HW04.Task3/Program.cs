using System;

namespace HW04.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number:");
            string num1Txt = Console.ReadLine();
            while (Program.NumCheck(num1Txt) == false)
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

            int result = Program.Add(num1, num2);

            Console.WriteLine("Enter the RESULT of add:");
            string resultTxt = Console.ReadLine();
            while (Program.NumCheck(resultTxt) == false)
            {
                Console.WriteLine("ERROR!!! You entered not a number! Enter the RESULT again:");
                resultTxt = Console.ReadLine();
            }
            int userResult = Convert.ToInt32(resultTxt);

            while (userResult != result)
            {
                Console.WriteLine("WRONG!");
                if (userResult > result)
                {
                    Console.WriteLine("Correct RESULT is less!");
                }
                if (userResult < result)
                {
                    Console.WriteLine("Correct RESULT is bigger!");
                }
                resultTxt = Console.ReadLine();
                while (Program.NumCheck(resultTxt) == false)
                {
                    Console.WriteLine("ERROR!!! You entered not a number! Enter the RESULT again:");
                    resultTxt = Console.ReadLine();
                }
                userResult = Convert.ToInt32(resultTxt);
            }
            Console.WriteLine("CORRECT Result!!!");
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
