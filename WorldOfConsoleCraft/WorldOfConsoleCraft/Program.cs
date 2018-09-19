using System;
using WorldOfConsoleCraft.Resources;
using static System.Console;

namespace WorldOfConsoleCraft
{
    class Program
    {
        static Character test2 = new Character("Per Olson", 100, 1, 0, 0, 0, 100);
        static CoreGameLogic test = new CoreGameLogic();
        static Text AsciiArt = new Text();

        static void Main(string[] args)
        {//"Per Olson", 100, 1, 0, 0, 0, 100
            var introText = AsciiArt.AsciiIntro();
            WriteLine(introText);

            WriteLine($"Hello {test2.Name}");
            while (true)
            {
                if (ReadLine()?.ToLower() == "k")
                {
                    var outputExp = test.CalculateExp(test2.ExperiencePoints);
                    WriteLine($"{outputExp} Experience points gained");
                }
                else
                {
                    WriteLine("Wrong input");
                }
                
            }


        }
    }
}
