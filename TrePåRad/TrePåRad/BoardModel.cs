using System;
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
        // {'x', '0', ' ', ' ', }
        //public void ModelLogic()
        //{
        //    CheckVictoryCondition();
   

        public void SetCross(string position)
        {
            switch (position)
            {
                case "a1":
                    if (Content[0] != 'o')
                        Content[0] = 'x';
                    break;
                case "a2":
                    if (Content[3] != 'o')
                        Content[3] = 'x';
                    break;
                case "a3":
                    if (Content[6] != 'o')
                        Content[6] = 'x';
                    break;
                case "b1":
                    if (Content[1] != 'o')
                        Content[1] = 'x';
                    break;
                case "b2":
                    if (Content[4] != 'o')
                        Content[4] = 'x';
                    break;
                case "b3":
                    if (Content[7] != 'o')
                        Content[7] = 'x';
                    break;
                case "c1":
                    if (Content[2] != 'o')
                        Content[2] = 'x';
                    break;
                case "c2":
                    if (Content[5] != 'o')
                        Content[5] = 'x';
                    break;
                case "c3":
                    if (Content[8] != 'o')
                        Content[8] = 'x';
                    break;
                default:
                    Console.WriteLine("Error in input, check your string");
                    break;

            }

        }

        public void SetRandomCircle()
        {//TO DO : Fix this, currently a bit broken
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
