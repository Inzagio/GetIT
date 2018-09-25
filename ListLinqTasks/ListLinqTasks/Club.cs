using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLinqTasks
{
    class Club : IEnumerable
    {
        public string Name { get; }
        public List<Registration> clubList { get; } = new List<Registration>();

        public Club(string name)
        {
            Name = name;
        }

        public void AddToClubList(Registration clubNames)
        {
            clubList.Add(clubNames);
        }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
