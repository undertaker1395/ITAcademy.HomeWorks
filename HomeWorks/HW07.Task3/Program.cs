using System;

namespace HW07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");
            string inputInfo = Console.ReadLine();
            char[] signs = inputInfo.ToCharArray();
            string firstNum = string.Empty;
            int numIndex = 0;
            int numIndex2 = 0;
            string secondNum = string.Empty;
            int mathSignPos = 0;
            for(int i = 0; i < signs.Length; i++)
            {
                    if (signs[i] == '*' || signs[i] == '/' || signs[i] == '+' || signs[i] == '-') mathSignPos = i; 
            }
            for (int i = 0; i < mathSignPos; i++)
            {
                if (char.IsNumber(signs[i]))
                {
                    firstNum = firstNum.Insert(numIndex, Convert.ToString(signs[i]));
                    numIndex++;
                }
            }
            for (int i = mathSignPos; i < signs.Length; i++)
            {
                if (char.IsNumber(signs[i]))
                {;
                    secondNum = secondNum.Insert(numIndex2, Convert.ToString(signs[i]));
                    numIndex2++;
                }
            }
            if (signs[mathSignPos] == '*') Console.WriteLine("Result: " + (Convert.ToInt32(firstNum) * Convert.ToInt32(secondNum)));
            if (signs[mathSignPos] == '/') Console.WriteLine("Result: " + (Convert.ToInt32(firstNum) / Convert.ToInt32(secondNum)));
            if (signs[mathSignPos] == '+') Console.WriteLine("Result: " + (Convert.ToInt32(firstNum) + Convert.ToInt32(secondNum)));
            if (signs[mathSignPos] == '-') Console.WriteLine("Result: " + (Convert.ToInt32(firstNum) - Convert.ToInt32(secondNum)));

        }
    }
}
