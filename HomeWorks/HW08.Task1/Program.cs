using System;
using System.Text;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("1a!2.3!!..4.!.? 6 7!.. ?");
            Console.WriteLine(sb);
            char[] charArr = sb.ToString().ToCharArray();
            int signPos = 0;
            for(int i = 0; i < charArr.Length; i++)
            {
                if(charArr[i] == '?')
                {
                    signPos = i;
                    break;
                }
            }
            sb.Replace(" ", "_", signPos, sb.Length - signPos);
            Console.WriteLine(sb);
            sb.Replace("!", "", 0, signPos);
            Console.WriteLine(sb);
        }
    }
}
