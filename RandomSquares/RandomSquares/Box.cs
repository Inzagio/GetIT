using System;

namespace RandomSquares
{
    public class Box
    {


        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        private int _minSize = 3;

        public Box(Random random, int maxX, int maxY)
        {
            X = random.Next(0, maxX - _minSize);
            Y = random.Next(0, maxY - _minSize);
            Height = random.Next(_minSize, maxY - Y);
            Width = random.Next(_minSize, maxX - X);
        }

        public Box(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public int GetTopRowY()
        {
            return Y;
        }

        public int GetBottomRowY()
        {
            return Y + Height;
        }
    }
}
