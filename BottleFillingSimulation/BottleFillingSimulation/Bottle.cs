using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleFillingSimulation
{
    class Bottle
    {
        public int Capacity { get; }
        public int Content;

        public Bottle(int capacity)
        {
            Capacity = capacity;
        }

        public void FillFromTap()
        {
            Content = Capacity;
        }

        public void Fill(int amount)
        {
            if (Content + amount <= Capacity)
            {
                Content += amount;
            }
        }

        public void FillToTop(Bottle bottle)
        {
            var spaceLeft = Capacity - Content;
            if (spaceLeft > 0 && spaceLeft < bottle.Content)
            {
                Content = Capacity;
                bottle.Content -= spaceLeft;
            }
        }

        public int Empty()
        {
            var oldContent = Content;
            Content = 0;
            return oldContent;
        }
    }
}
