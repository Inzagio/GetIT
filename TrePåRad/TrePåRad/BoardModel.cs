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
            if (position == "a1")
            {
                if (Content[0] != 'o')
                    Content[0] = 'x';
            }
            else if (position == "a2")
            {
                if (Content[3] != 'o')
                    Content[3] = 'x';
            }
            else if (position == "a3")
            {
                if (Content[6] != 'o')
                    Content[6] = 'x';
            }
            else if (position == "b1")
            {
                if (Content[1] != 'o')
                    Content[1] = 'x';
            }
            else if (position == "b2")
            {
                if (Content[4] != 'o')
                    Content[4] = 'x';
            }
            else if (position == "b3")
            {
                if (Content[7] != 'o')
                    Content[7] = 'x';
            }
            else if (position == "c1")
            {
                if (Content[2] != 'o')
                    Content[2] = 'x';
            }
            else if (position == "c2")
            {
                if (Content[5] != 'o')
                    Content[5] = 'x';
            }
            else if (position == "c3")
            {
                if (Content[8] != 'o')
                    Content[8] = 'x';
            }
            else
            {
                WriteLine("Error in input, check your string");
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
