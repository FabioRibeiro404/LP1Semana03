using System;

namespace HeroPerks
{
    [Flags]
    enum Perks
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
            Perks MyClass = 0;

            foreach (string s in args)
            {
                playerPerks = s;
            }

            

            for (int i = 0; i < playerPerks.Length; i++)
            {
                if (playerPerks[i] == 'w')
                {
                    MyClass ^= Perks.WaterBreathing;
                }
                else if (playerPerks[i] == 's')
                {
                    MyClass ^= Perks.Stealth;
                }
                else if (playerPerks[i] == 'a')
                {
                    MyClass ^= Perks.AutoHeal;
                }
                else if (playerPerks[i] == 'd')
                {   
                    MyClass ^= Perks.DoubleJump;
                }
                else if (playerPerks[i] != 'w' || playerPerks[i] != 's'||
                    playerPerks[i] != 'a'|| playerPerks[i] != 'd')
                    {
                        Console.WriteLine("Unknown perk!");
                        return;
                    }
            }
            if (MyClass != 0)
                Console.WriteLine(MyClass);

            if ((MyClass & Perks.Stealth) == Perks.Stealth 
            && (MyClass & Perks.DoubleJump) == Perks.DoubleJump)
            {
                Console.WriteLine("Silent jumper!");
            }

            if (MyClass == 0)
            {
                Console.WriteLine("No perks at all!");
            }

            if ((MyClass & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
            



        }
        
    }
}
