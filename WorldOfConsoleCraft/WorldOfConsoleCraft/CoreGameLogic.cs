using System;
using System.Net.Mime;

namespace WorldOfConsoleCraft
{
    internal class CoreGameLogic
    {
      

        public static Character Character;
       
        
        //public CoreGameLogic(Character character)
        //{
        //    Character = character;
        //    CombatLogic =  new CombatLogic(character);
        //} 

        public static int CalculateExp(int ExperiencePoints)
        {
            ExperiencePoints = Character.UpdateExperience();
            CheckIfLeveled();
            return ExperiencePoints;
        }

        public static void CheckIfLeveled()
        {
            var xpToLevel = Character.XpToLevel;
            if (Character.ExperiencePoints == xpToLevel)
            {
                Character.LevelUp(xpToLevel);
            }
        }

     

        public static void StartGame()
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
                    Console.WriteLine("Wrong input");
                }

            }
        }
    }
}
