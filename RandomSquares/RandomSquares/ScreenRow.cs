using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSquares
{
    class ScreenRow
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
            _cells[startX].AddUpperLeftCorner();
            _cells[endX].AddUpperRightCorner();
            for (var index = startX + 1; index < endX; index++)
            {
                _cells[index].AddVertical();
            }
        }

        public void Show(int startX, int width)
        {
            AddBottomRow(startX, width);
        }
    }
}
