using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace TrePåRad
{
    class Program
    {
        static void Main()
        {
            //BoardView.Show();
            //BoardModel boardLogic = new BoardModel();
            //boardLogic.ModelLogic();
            var boardModel = new BoardModel();
            while (true)
            {
                GameLogic test = new GameLogic();
                BoardView.Show(boardModel);
                test.CheckVictoryCondition(boardModel);

                Console.Write("Type where you want to place X (e.g \"a2\"): ");
                var position = Console.ReadLine();
                boardModel.SetCross(position);

                if (CheckWinner(boardModel)) break;
                Thread.Sleep(2000);

                boardModel.SetRandomCircle();
                if(CheckWinner(boardModel))break;
            }
                RestartProgram();

        }

        static bool CheckWinner(BoardModel bm)
        {
            GameLogic checkWinz = new GameLogic();
            var checkWin = checkWinz.CheckVictoryCondition(bm);
            if (!checkWin) return false;
            BoardView.Show(bm);
            Console.WriteLine("");
            Console.WriteLine($"{GameLogic.Winner} won!");
            return true;
        }

        static void RestartProgram()
        {
            Console.WriteLine("Press 'r' to restart the game");
            var keyRead = Console.ReadKey();
            if (keyRead.KeyChar == 'r')
            {
               
               Main();
            }
            
        }
    }
}
