namespace RandomSquares
{
    public class ScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public char GetCharacter()
        {
            //var returnValue = ' ';

            //if (Up && Down && Left && Right) return '┼';
            //if (Up && Down && Left && !Right) return '┤';

            //if (Up && Down && !Left && Right) return '├';
            //if (Up && Down && !Left && !Right) return '│';

            //if (Up && !Down && Left && Right) return '┴';
            //if (!Up && Down && Left && Right) return '┬';

            //if (!Up && !Down && Left && Right) return '─';

            //if (Up && !Down && !Left && Right) return '┘';
            //if (!Up && Down && !Left && Right) return '┐';

            //if (Up && !Down && Left && !Right) return '└';
            //if (!Up && Down && Left && !Right) return '┌';

            //return ' ';

            if (Up && Down && Left && Right) return '┼';
            if (Up && Down && Left && !Right) return '┤';
            if (Up && Down && !Left && Right) return '├';
            if (Up && Down && !Left && !Right) return '│';
            if (Up && !Down && Left && Right) return '┴';
            if (Up && !Down && Left && !Right) return '┘';
            if (Up && !Down && !Left && Right) return '└';
            if (Up && !Down && !Left && !Right) return '╵';

            if (!Up && Down && Left && Right) return '┬';
            if (!Up && Down && Left && !Right) return '┐';
            if (!Up && Down && !Left && Right) return '┌';
            if (!Up && Down && !Left && !Right) return '╷';
            if (!Up && !Down && Left && Right) return '─';
            if (!Up && !Down && Left && !Right) return '╴';
            if (!Up && !Down && !Left && Right) return '╶';
            return ' ';
        }

        public void AddHorizontal()
        {
            Right = true;
            Left = true;
        }

        public void AddVertical()
        {
            Up = true;
            Down = true;
        }

        public void AddLowerLeftCorner()
        {
            Up = true;
            Right = true;
        }

        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;
        }

        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;
        }

        public void AddLowerRightCorner()
        {
            Up = true;
            Left = true;
        }
    }
}
