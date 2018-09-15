using System;
using System.Threading;

namespace TrePåRad
{
    class Program
    {
        static void Main(string[] args)
        {
            //BoardView.Show();
            //BoardModel boardLogic = new BoardModel();
            //boardLogic.ModelLogic();
            var boardModel = new BoardModel();
            while (true)
            {
                BoardView.Show(boardModel);
                Console.Write("Type where you want to place X (e.g \"a2\"): ");
                var position = Console.ReadLine();
                boardModel.SetCross(position);
                Thread.Sleep(2000);
                boardModel.SetRandomCircle();
            }
        }
    }
}
