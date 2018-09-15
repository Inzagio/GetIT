using System;


namespace TrePåRad
{
    class BoardView
    {


        public static void Show(BoardModel bm)
        {
            Console.Clear();
            Console.WriteLine($"  a b c");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine($"1│{bm.Content[0]} {bm.Content[1]} {bm.Content[2]}│");
            Console.WriteLine($"2│{bm.Content[3]} {bm.Content[4]} {bm.Content[5]}│");
            Console.WriteLine($"3│{bm.Content[6]} {bm.Content[7]} {bm.Content[8]}│");
            Console.WriteLine(" └─────┘");
        }
    }
}
