using System;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Players: ");
            string str1 = Console.ReadLine();
            int n = int.Parse(str1);

            Powers [] playersPowers = new Powers[n];

            for (int i = 0; i < playersPowers.Length; i++)
            {
                
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"Player {i} choose your Power: ");
                    string str2 = Console.ReadLine();
                    if (str2 == "Fly")
                    {
                        playersPowers[i] ^= Powers.Fly;
                    }
                    else if (str2 == "XRayVision")
                    {
                        playersPowers[i] ^= Powers.XRayVision;
                    }
                    else if (str2 == "SuperStrength")
                    {
                        playersPowers[i] ^= Powers.SuperStrength;
                    }
                    else
                        continue;
                }
                
                if ((playersPowers[i] & Powers.Fly) == Powers.Fly
                    && ((playersPowers[i] & Powers.SuperStrength) == Powers.SuperStrength))
                {
                    Console.WriteLine("Flying radiation");
                }
                
            }
        }
    }
}
