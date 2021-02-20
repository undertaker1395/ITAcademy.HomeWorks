using System;

namespace HW._05.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting();

            switch (greeting.Hours(DateTime.Now.TimeOfDay))
            {
                case 9:
                case 10:
                case 11:
                    Console.WriteLine(DateTime.Now.TimeOfDay);
                    Console.WriteLine("Good Morning, guys");
                    break;
                case 12:
                case 13:
                case 14:
                    Console.WriteLine(DateTime.Now.TimeOfDay);
                    Console.WriteLine("Good Day, guys");
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                    Console.WriteLine(DateTime.Now.TimeOfDay);
                    Console.WriteLine("Good Evening, guys");
                    break;
                default:
                    Console.WriteLine("Why are you not sleeping? Go sleep NOW!!!");
                    break;
            }

            
        }
    }
    class Greeting
    {
        public int Hours(TimeSpan dayTime)
        {
            int h = dayTime.Hours;
            return h;
        }
    }
}
