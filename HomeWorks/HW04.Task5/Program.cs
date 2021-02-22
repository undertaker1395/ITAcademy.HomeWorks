using System;

namespace HW04.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int unicode = 90;
            for(int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)unicode);
                unicode--;
            }
        }
    }
}
