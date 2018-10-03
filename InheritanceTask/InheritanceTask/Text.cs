using System;

namespace InheritanceTask
{
    class Text : Shape
    {

        public Text(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Text(Random random) : base(random)
        {
            DirectionX = random.Next(0, 1);
            DirectionY = random.Next(0, 1);
        }

        public override string GetCharacter(int row, int col)
        {
            return "Hurra!";
        }

    }
}
