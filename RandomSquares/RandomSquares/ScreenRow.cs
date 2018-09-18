using System;
using System.Text;

namespace RandomSquares
{
   public class ScreenRow
    {
        private readonly ScreenCell[] _cells;
        private int _width;
        private int _startX;

        public ScreenRow(int width, int startX)
        {
            _cells = new ScreenCell[width + startX];
            for (var index = 0; index < _cells.Length; index++)
            {
                _cells[index] = new ScreenCell();
            }
        }

        public void AddTopRow(int startX, int width)
        {
            var endX = startX + width;
            _cells[startX].AddUpperLeftCorner();
            _cells[endX].AddUpperRightCorner();
            for (var index = startX + 1; index < endX; index++)
            {
                _cells[index].AddHorizontal();
            }
        }

        public void AddBottomRow(int startX, int width)
        {
            var endX = startX + width;
            _cells[startX].AddLowerLeftCorner();
            _cells[endX].AddLowerRightCorner();
            for (var index = startX + 1; index < endX; index++)
            {
                _cells[index].AddHorizontal();
            }
        }

        public void AddMiddleRow(int startX, int width)
        {
            var endX = startX + width;
            _cells[startX].AddVertical();
            _cells[endX].AddVertical();
            
        }

        public void Show()
        {
            var output = new StringBuilder();
            foreach (var cell in _cells)
            {
                output.Append(cell.GetCharacter());
            }

            Console.WriteLine(output);
        }
    }
}
