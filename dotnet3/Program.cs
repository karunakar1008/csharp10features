using System;
using System.Text.Json;

namespace dotnet3
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
