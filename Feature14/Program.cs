// See https://aka.ms/new-console-template for more information
Console.WriteLine("List patterns extend pattern matching to match sequences of elements in a list or an array");

var numbers = new[] { 1, 2, 3, 4 };

// List and constant patterns 
Console.WriteLine(numbers is [1, 2, 3, 4]); // True 
Console.WriteLine(numbers is [1, 2, 4]); // False

// List and discard patterns 
Console.WriteLine(numbers is [_, 2, _, 4]); // True 
Console.WriteLine(numbers is [.., 3, _]); // True

Console.WriteLine(numbers is [_,_, 3, _]); // True
//Console.WriteLine(numbers is [_,_,_, 4]); // True //Ending with 4

// List and logical patterns 
//Console.WriteLine(numbers is [_, >= 2, _, _]); // True


List<int> myList = new() { 1, 2, 3 };

if (myList is [var first, _, _])
{
    Console.WriteLine($"The first element of a three-item list is {first}.");
}