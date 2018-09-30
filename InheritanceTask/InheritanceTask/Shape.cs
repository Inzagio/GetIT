using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    abstract class Shape
    {
        public int DirectionX { get; internal set; }
        public int DirectionY { get; internal set; }
        public int X { get; internal set; }
        public int Y { get; internal set; }

        protected Shape()
        {
            
        }

        protected Shape(Random random)
        {
            DirectionX = random.Next(0, 2);
            DirectionY = random.Next(0, 2);
        }
        public void Move()
        {
            X += DirectionX;
            Y += DirectionY;
        }

        public abstract string GetCharacter(int row, int col);
    }
}
