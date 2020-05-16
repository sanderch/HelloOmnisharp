using System;

namespace HelloOmnisharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();
            Console.WriteLine("Hello World!");
                Console.WriteLine(human.type);
            ConsoleColor backgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
        }
    }
}

