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

            HttpStyleUriParser parser = new HttpStyleUriParser(); 
            WriteColored(parser.ToString(), ConsoleColor.Red);
            WriteColored(parser.GetType().ToString(), ConsoleColor.Magenta);

            WriteColored(intParse("abc").ToString(), ConsoleColor.Red);
            WriteColored(intParse("1234").ToString(), ConsoleColor.Red);
            WriteColored(intParse("0").ToString(), ConsoleColor.Red);
            WriteColored(intParse("00asd").ToString(), ConsoleColor.Red);
            WriteColored(intParse("").ToString(), ConsoleColor.Red);
            WriteColored(intParse(null).ToString(), ConsoleColor.Red);
        }

        private static void WriteColored(string str, ConsoleColor color)
        {
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ForegroundColor = foregroundColor;
        }

        private static int intParse(string str){
            int result = int.TryParse(str, out result) ? result : 42;    
            return result;
        }
    }
}

