// See https://aka.ms/new-console-template for more information

//Feature-1: Global usings
//what is ImplicitUsings

Console.WriteLine("Hello, World!");
var names = new[] { "Karunaa", "Sravan", "Amit" };
var serialized=JsonSerializer.Serialize(names);
Console.WriteLine(serialized);
