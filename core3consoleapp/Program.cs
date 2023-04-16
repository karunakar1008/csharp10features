using System;
using System.Text.Json;

namespace core3consoleapp
{
    internal class Program
    {
        static void Main()
        {
            var names = new[] { "Karunaa", "Sravan", "Amit" };
            var serialized = JsonSerializer.Serialize(names);
            Console.WriteLine(serialized);
        }
    }
}
