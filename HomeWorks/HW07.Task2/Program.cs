using System;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string inputStr = Console.ReadLine();
            Console.WriteLine("Deleted the longest word:");
            Console.WriteLine(Program.NoLongWord(inputStr));
            Console.WriteLine("Changed the longest and the shortest words:");
            Console.WriteLine(Program.LongShortExch(inputStr));
            Console.WriteLine("Count leters and signs:");
            Console.WriteLine(Program.LeterCount(inputStr));
            Console.WriteLine("From the shortest to the longest:");
            Console.WriteLine(Program.FromSToL(inputStr));
        }

        static string NoLongWord(string newStr)
        {
            string[] strArr = newStr.Split(' ');
            string maxLWord = string.Empty;
            int count = 0;
            for (int i = 0; i < strArr.Length; i++)
                if (strArr[i].Length > maxLWord.Length)
                {
                    maxLWord = strArr[i];
                    count = i;
                }
            string[] newArr = new string[strArr.Length - 1];
            for (int i = 0; i < count; i++)
            {
                newArr[i] = strArr[i];
            }
            for (int i = count; i < newArr.Length; i++)
            {
                newArr[i] = strArr[i+1];
            }
            return string.Join(' ', newArr);
        }

        static string LongShortExch(string newStr)
        {
            string[] strArr = newStr.Split(' ');
            string maxLWord = string.Empty;
            string minLWord = string.Empty;
            int indexL = 0;
            int indexS = 0;
            for (int i = 0; i < strArr.Length; i++)
                if (strArr[i].Length > maxLWord.Length)
                {
                    maxLWord = strArr[i];
                    indexL = i;
                }
            minLWord = maxLWord;
            for (int i = 0; i < strArr.Length; i++)
                if (strArr[i].Length < minLWord.Length)
                {
                    minLWord = strArr[i];
                    indexS = i;
                }
            string[] newArr = new string[strArr.Length];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (indexL == i)
                {
                    newArr[i] = minLWord;
                }
                else
                {
                    if (indexS == i)
                    {
                        newArr[i] = maxLWord;
                    }
                    else
                    {
                        newArr[i] = strArr[i];
                    }
                }
            }
            return string.Join(' ', newArr); 
        }
        static string FromSToL(string newStr)
        {
            string[] strArr = newStr.Split(' ');
            string word;
            for (int i = 0; i < newStr.Length - 1; i++)
            {
                for (int j = i + 1; j < strArr.Length; j++)
                {
                    if (strArr[i].Length > strArr[j].Length)
                    {
                        word = strArr[i];
                        strArr[i] = strArr[j];
                        strArr[j] = word;
                    }
                }
            }
            return string.Join(' ', strArr);
        }
        static string LeterCount(string newStr)
        {
            string upStr = newStr.ToUpper();
            char[] byLeters = upStr.ToCharArray();
            int leterCount = 0;
            int signCount = 0;
            foreach(char c in byLeters)
            {
                if (c >= 65 && c <= 90)
                {
                    leterCount++;
                }
                else
                {
                    if(c == 32)
                    {

                    }
                    else
                    {
                        signCount++;
                    }
                } 
            }
            string finStr = "Leters: " + leterCount + "\n" + "Signs: " + signCount;
            return finStr; 
        }
    }
}
