using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please use W/A/S/D keys to select direction");
            string dir;
            char dirChar;
            int x = 0;

            int up = 87;
            int down = 83;
            int left = 65;
            int right = 68;
            int upS = 119;
            int downS = 115;
            int leftS = 97;
            int rightS = 100;
            while (true)
            {
                dir = Console.ReadLine();
                dirChar = Convert.ToChar(dir);

                if (dirChar == (char)up || dirChar == (char)upS)
                {
                    if (x == 1)
                    {
                        Console.WriteLine("Same direction");
                    }
                    else
                    {
                        x = 1;
                        Console.WriteLine("Up direction");
                    }
                }
                if (dirChar == (char)down || dirChar == (char)downS)
                {
                    if (x == 2)
                    {
                        Console.WriteLine("Same direction");
                    }
                    else
                    {
                        x = 2;
                        Console.WriteLine("Down direction");
                    }
                }
                if (dirChar == (char)left || dirChar == (char)leftS)
                {
                    if (x == 3)
                    {
                        Console.WriteLine("Same direction");
                    }
                    else
                    {
                        x = 3;
                        Console.WriteLine("Left direction");
                    }
                }
                if (dirChar == (char)right || dirChar == (char)rightS)
                {
                    if (x == 4)
                    {
                        Console.WriteLine("Same direction");
                    }
                    else
                    {
                        x = 4;
                        Console.WriteLine("Right direction");
                    }
                }
            }
        }
    }
}
