using System;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string NoLongWord(string newStr)
        {
            string[] strArr = newStr.Split(' ');
            string maxLWord = string.Empty;
            for (int i = 0; i < strArr.Length; i++)
                if (strArr[i].Length > maxLWord.Length)
                    maxLWord = strArr[i];
            for (int i = 0; i < strArr.Length; i++)
                if (strArr[i] == maxLWord)
                    strArr[i] = null;
            return string.Join(' ', strArr);
        }
    }
}
