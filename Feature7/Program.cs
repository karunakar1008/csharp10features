
//Extended property pattern

using Feature7;

Console.WriteLine("Hello, World!");

var rectangleInside = new Rectangle(10, 20);
var rectangleOutside = new Rectangle(20, 40, rectangleInside);

if (rectangleOutside is { rectangle: { height: >= 10 } })
{
    Console.WriteLine("Outer rectangle is begger than inner rectangle");
}

