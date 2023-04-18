Console.WriteLine("Hello, World!");
var names = new[] { "Karunaa", "Sravan", "Amit" };
var serialized=JsonSerializer.Serialize(names);
Console.WriteLine(serialized);
