using static System.Console;

namespace WorldOfConsoleCraft
{
    class Program
    {
        static Character test2 = new Character("Per Olson", 100, 1, 0, 0, 0, 100);
        static CoreGameLogic test = new CoreGameLogic();
        static void Main(string[] args)
        {//"Per Olson", 100, 1, 0, 0, 0, 100
            while (true)
            {
                WriteLine(test2.Name);
                if (ReadLine()?.ToLower() == "kill")
                {
                    var hei = test.CalculateExp(test2.ExperiencePoints);
                    WriteLine(hei);
                }
            }


        }
    }
}
