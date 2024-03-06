using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a phrase: ");
            string phrase = Console.ReadLine();
            Console.WriteLine("Insert character to remove: ");
            string remove = Console.ReadLine();
            char verify = char.Parse(remove);

            for (int i = 0; i < phrase.Length; i++)
            {
                if (verify == phrase[i])
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(phrase[i]);
                }
            }
        }
    }
}
