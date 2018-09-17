using System;

namespace RandomSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            var cell = new ScreenCell();
            cell.AddVertical();
            cell.AddHorizontal();
            cell.AddLowerLeftCorner();
            cell.AddLowerRightCorner();
            cell.AddUpperLeftCorner();
            cell.AddUpperRightCorner();
            var test = cell.GetCharacter();
            Console.WriteLine(test);
        }
    }
}
