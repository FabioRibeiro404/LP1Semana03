using System;

namespace HeroPerks
{
    [Flags]
    enum HeroPerks
    {
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    };

    class Program
    {
        static void Main(string[] args)
        {
            string playerPerks = "";

            foreach (string s in args)
            {
                playerPerks = s;
            }

            //Console.WriteLine(playerPerks);
            int counterW = 0;
            int counterS = 0;
            int counterA = 0;
            int counterD = 0;

            for (int i = 0; i < playerPerks.Length; i++)
            {
                if (playerPerks[i] == 'w')
                {
                    counterW++;
                }
                else if (playerPerks[i] == 's')
                {
                    counterS++;
                }
                else if (playerPerks[i] == 'a')
                {
                    counterA++;
                }
                else if (playerPerks[i] == 'd')
                {
                    counterD++;
                }
                else if (playerPerks[i] != 'w' || playerPerks[i] != 's'||
                    playerPerks[i] != 'a'|| playerPerks[i] != 'd')
                    {
                        Console.WriteLine("Unknown perk!");
                    }
            }
        }
        
    }
}
