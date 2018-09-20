using System;

namespace WorldOfConsoleCraft
{
    internal class Character
    {
        public string Name { get; }
        public int HealthPoints { get; }
        public int Level { get; set; }
        public int PositionX { get; }
        public int PositionY { get; }
        public int ExperiencePoints { get; set; }
        public int XpToLevel { get; set; }

        public Character(string name)
        {
            Name = name;
            HealthPoints = 100;
            Level = 1;
            PositionX = 0;
            PositionY = 0;
            ExperiencePoints = 0;
            XpToLevel = 100;
        }
        public int UpdateExperience()
        {
            ExperiencePoints++;

            return ExperiencePoints;
        }

        public void LevelUp(int xpToLevel)
        {
            Level++;
            Console.WriteLine($"You are now level {Level}");
            double increment = 1.5;
            XpToLevel =(int) Math.Round(xpToLevel* increment);
        }
    }
}
