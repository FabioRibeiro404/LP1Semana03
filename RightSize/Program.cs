using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string s in args)
            {
                if (s.Length > 3 && s.Length < 6)
                {
                    Console.WriteLine(s);
                }

                else if (s.Length > 6)
                    break;

                else
                    continue;
            }
        }
    }
}
