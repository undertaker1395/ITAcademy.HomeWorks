using System;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the word:");
            string word = Console.ReadLine();
            int wordL = word.Length - 1;
            int x = 0;
            for (int i = 0; i <= wordL; i++)
            {
                char a = 'a';
                char bigA = 'A';
                char aKirr = 'а';
                char aKirrBig = 'А';
                if (word[i] == a || word[i] == bigA || word[i] == aKirr || word[i] == aKirrBig)
                {
                    x++;
                }
            }
            Console.WriteLine("There are " + x + " leters 'a' in this word.");
            
        }
    }
}
