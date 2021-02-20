using System;

namespace HW._05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number above 0:");
            string numTxt = Console.ReadLine();
            while (Program.NumCheck(numTxt) == false)
            {
                Console.WriteLine("ERROR!!! Enter the number again:");
                numTxt = Console.ReadLine();
            }
            int num = Convert.ToInt32(numTxt);
            int result = 0;
            for(int i = 0; i <= num; i++)
            {
               result = result + i;  
            }
            Console.WriteLine(result);
        }
        static bool NumCheck(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!char.IsDigit(s[i])) return false;
            return true;
        }
    }
}
