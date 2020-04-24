using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Console.WriteLine(square.Circle(4));
            Console.WriteLine(square.Circle(7.3));
            Console.WriteLine(square.IsRectangular(4, 5, 6));
            Console.WriteLine(square.Triangle(5, 6, 7));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
