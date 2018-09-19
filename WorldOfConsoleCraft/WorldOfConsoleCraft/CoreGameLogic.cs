using System;

namespace WorldOfConsoleCraft
{
    class CoreGameLogic
    {
        public Character Character = new Character("Per Olson", 100, 1, 0, 0, 0, 100);

        public int CalculateExp()
        {
            return CalculateExp(0);
        }

        public int CalculateExp(int xp)
        {
            xp = Character.ExperiencePoints++;
            CheckIfLeveled();
            return xp;
        }

        public void CheckIfLeveled()
        {
            var xpToLevel = Character.XpToLevel;
            if (Character.ExperiencePoints == xpToLevel)
            {
                Character.Level ++;
                Console.WriteLine($"You are now level {Character.Level}");
                Character.XpToLevel = xpToLevel * 2;
            }

        }
    }
}
