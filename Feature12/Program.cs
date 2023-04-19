// See https://aka.ms/new-console-template for more information
using Feature12;

Console.WriteLine("1. Add required modifier to properties and fields to enforce constructors and callers to initialize those values");
Console.WriteLine("2. Add [SetsRequiredMembers] can be added to constructors to inform the compiler that a constructor initializes all required members.");

// Initializations with required properties 
var person1 = new Person { Name = "karunakar",Surname="Bhogyari"};

// Initializations with missing required properties 
//Person person2 = new Person { Name = "Shehryar" };
Console.WriteLine(person1.Name);

