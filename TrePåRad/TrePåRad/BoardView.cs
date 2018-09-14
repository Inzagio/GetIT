using System;


namespace TrePåRad
{
    class BoardView
    {


        public static void Show()
        {
            /* Note:
              * if (readInput == a2)
              * a2 = "x";
              */
            BoardModel cell = new BoardModel();
            DrawBoard(cell);
        }

        private static void DrawBoard(BoardModel cell)
        {
            Console.WriteLine($"  a b c");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine($"1│{cell.Content[0]} {cell.Content[1]} {cell.Content[2]}│");
            Console.WriteLine($"2│{cell.Content[3]} {cell.Content[4]} {cell.Content[5]}│");
            Console.WriteLine($"3│{cell.Content[6]} {cell.Content[7]} {cell.Content[8]}│");
            Console.WriteLine(" └─────┘");
          
        }
    }
}
