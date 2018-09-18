using System;
using System.Linq;
using System.Threading;
using static System.Console;

namespace TrePåRad
{
    class BoardModel
    {
        private readonly Random _random = new Random();


        public char[] Content =
        {

            ' ', ' ', ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' '
        };


        public void SetCross(string position)
        {
            CheckCross();

            var col = (int)(position[0] - 'a');
            var row = Convert.ToInt32(position[1].ToString()) - 1;
            var index = col + row * 3;

            if (Content[index] == ' ')
            {
                Content[index] = 'x';
            }
            
        }
        public void CheckCross()
        {
            if (Content.Contains('o'))
                WriteLine("Try somewhere else");
        }

        public void SetRandomCircle()
        {
            int randomCell;
            do
            {
                randomCell = _random.Next(0, 9);
                Thread.Sleep(5);
            } while (Content[randomCell] != ' ');
            Content[randomCell] = 'o';

        }
    }
}
