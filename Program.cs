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
            WriteColored(human, ConsoleColor.DarkYellow);
        }

        private static void WriteColored(Human human, ConsoleColor color)
        {
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(human.FullName);
        }
    }
}

