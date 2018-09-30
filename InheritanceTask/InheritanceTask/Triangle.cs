using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    class Triangle : Shape
    {
        public int Size { get;  private set ; }
        private int _minimumSize = 1;

        public Triangle(int x, int y, int size)
        {
            X = x;
            Y = y;
            Size = size;
        }

        public Triangle(Random random, int maxSize) : base(random)
        {
          
            Size = random.Next(_minimumSize, maxSize);
            X = random.Next(0, maxSize - Size);
            Y = random.Next(0, maxSize - Size); 
        }

        public override string GetCharacter(int row, int col)
        {
            if (row < Y || col < X -1) return null;

            var internalX = col - X;
            var internalY = row - Y;
            if (internalX >  2* Size + 2 || internalY > Size + 1) return null;
            if (internalY == Size + 1) return "-";
           
            var xPositionSlash = Size - internalY;
            var xPositionBackslash = Size + internalY + 1;

            if (internalX == xPositionSlash) return "/";
            if (internalX == xPositionBackslash) return "\\";
            return null;
        }
        
    }
}
