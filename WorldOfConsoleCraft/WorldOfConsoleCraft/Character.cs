namespace WorldOfConsoleCraft
{
    class Character
    {
        public string Name { get; }
        public int HealthPoints { get; }
        public int Level { get; set; }
        public int PositionX { get; }
        public int PositionY { get; }
        public int ExperiencePoints { get; set; }
        public int XpToLevel { get; set; }
        public string Stats { get; set; }

        public Character(string name, int healthPoints, int level, int positionX, int positionY, int experiencePoints, int xpToLevel)
        {
            Name = name;
            HealthPoints = healthPoints;
            Level = level;
            PositionX = positionX;
            PositionY = positionY;
            ExperiencePoints = experiencePoints;
            XpToLevel = xpToLevel;

        }

        //public Character()
        //{
        //    //Name = "Trym";
        //    //HealthPoints = 100;
        //    //Level = 1;
        //    //PositionX = 0;
        //    //PositionY = 0;
        //    //ExperiencePoints = 0;
        //    //XpToLevel = 100;   
        //}
    }
}
