using System;

namespace HelloOmnisharp
{
    public class Human
    {
        public Human()
        {
            this.type = "homo sapiens";
        }
        public string type { get; set; }
        DateTime BirthDate { get; set; }
        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }
    }
}
