using System;
using System.Globalization;

namespace RandomSquares
{

    public class Screen
    {
        private ScreenRow[] _rows;

        public Screen(int width, int height)
        {
            _rows = new ScreenRow[height];
            for (var i = 0; i < _rows.Length; i++)
            {
                _rows[i] = new ScreenRow(width,0);
            }
        }

        public void Add(Box box)
        {
            var topRowY = box.GetTopRowY();
            var btmRowY = box.GetBottomRowY();
            _rows[topRowY].AddTopRow(box.X, box.Width);
            _rows[btmRowY].AddBottomRow(box.X, box.Width);
            for (int rowId = topRowY + 1; rowId < btmRowY; rowId++)
            {
                _rows[rowId].AddMiddleRow(box.X, box.Width);
            }
        }

        public void Show()
        {
            Console.Clear();
            foreach (var row in _rows)
            {
                row.Show();
            }
        }
    }

}
