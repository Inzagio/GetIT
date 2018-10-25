using System;
using System.Threading;

namespace InheritanceTask
{
    class Program
    {
        private static int _width = 50;
        private static int _height = 20;

        static void Main(string[] args)
        {
            var shapes = CreateShapes();
            var n = 10;
            while (n-- > 0)
            {
                Show(shapes);
                foreach (var shape in shapes)
                {
                    shape.Move();
                }
                Thread.Sleep(300);
            }
        }

        private static Shape[] CreateShapes()
        {
            var random = new Random();
            var shapes = new Shape[10];
            shapes[0] = new Text(random, _width, _height);
            for (var i = 1; i < shapes.Length; i++)
            {
                var shapeInt = random.Next(0, 2);
                if (shapeInt == 0)
                    shapes[i] = new Rectangle(random, _width, _height);
                else if (shapeInt == 1)
                    shapes[i] = new Triangle(random, _height);
            }
            return shapes;
        }

        private static void Show(Shape[] shapes)
        {
            Console.Clear();
            for (var row = 0; row < _height; row++)
            {
                Console.CursorTop = row;
                for (var col = 0; col < _width; col++)
                {
                    Console.CursorLeft = col;
                    var hasFoundCharacterToPrint = false;
                    foreach (var shape in shapes)
                    {
                        var character = shape.GetCharacter(row, col);
                        if (character != null)
                        {
                            Console.Write(character);
                            hasFoundCharacterToPrint = true;
                            break;
                        }
                    }
                    if (!hasFoundCharacterToPrint) Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
