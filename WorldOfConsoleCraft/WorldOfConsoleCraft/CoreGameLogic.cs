using System;
using System.Net.Mime;

namespace WorldOfConsoleCraft
{
    internal class CoreGameLogic
    {
        public Character Character;

        public CoreGameLogic(Character character)
        {
            Character = character;
        } 

        public int CalculateExp(int xp)
        {
            xp = Character.UpdateExperience();
            CheckIfLeveled();
            return xp;
        }

        public void CheckIfLeveled()
        {
            var xpToLevel = Character.XpToLevel;
            if (Character.ExperiencePoints == xpToLevel)
            {
                Character.LevelUp(xpToLevel);
            }
        }

        public  void StartGame()
        {
            var count = 0;
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.K)
                {
                    Console.Clear();
                    Console.WriteLine(Resources.Text.Art[count]);
                    count++;
                    if (count == Resources.Text.Art.Length) count = 0;
                    CalculateExp(Character.ExperiencePoints);
                    // Console.WriteLine($"{outputExp} Experience points gained - Need: {Character.XpToLevel} xp for next level");
                    
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }

            }
        }
    }
}
