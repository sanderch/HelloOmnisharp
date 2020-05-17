using System;

namespace HelloOmnisharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human()
            {
                FirstName = "John",
                MiddleName = "Iben",
                LastName = "Doe"
            };
            Console.WriteLine("Hello World!");
            Console.WriteLine(human.type);
            WriteColored(human.FullName, ConsoleColor.DarkYellow);
        }

        private static void WriteColored(string str, ConsoleColor color)
        {
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(str);
        }
    }
}

