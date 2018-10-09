using System;

namespace InheritanceTask
{
    class Text : Shape
    {
        private string _text = "Hurra!";
        private int _minimumSize = 1;


        public Text(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Text(Random random, int maxX, int maxY) : base(random)
        {
            X = random.Next(0, maxX - _minimumSize);
            Y = random.Next(0, maxY - _minimumSize);
        }

        public override string GetCharacter(int row, int col)
        {
            if (row != Y) return null;
            if (col < X || col >= X + _text.Length) return null;
            var index = col - X;
            return _text.Substring(index, 1);
        }

    }
}
