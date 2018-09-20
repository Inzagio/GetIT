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
            var character = new Character($"{playerName}");
            var coreGameLogic = new CoreGameLogic(character);
            var art = Text.Art;
            WriteLine(art[0]);
            WriteLine($"Hello {character.Name}");
            coreGameLogic.StartGame();
        }
    }
}
