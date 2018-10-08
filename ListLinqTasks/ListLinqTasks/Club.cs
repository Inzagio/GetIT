using System.Collections.Generic;

namespace ListLinqTasks
{
    class Club 
    {
        public string Name { get; }
        public List<Registration> ClubList { get; } = new List<Registration>();

        public Club(string name)
        {
            Name = name;
        }

        public void AddToClubList(Registration clubNames)
        {
            ClubList.Add(clubNames);
        }

    }
}
