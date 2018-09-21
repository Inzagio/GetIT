using System;
using WorldOfConsoleCraft.Resources;
using static System.Console;

namespace WorldOfConsoleCraft
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Write("Enter your name: ");
            var playerName = ReadLine();
            Clear();
            CoreGameLogic.Character = new Character($"{playerName}");
            var art = Text.Art;
            WriteLine(art[0]);
            WriteLine($"Hello {CoreGameLogic.Character.Name}");
            CoreGameLogic.StartGame();
        }
    }
}
