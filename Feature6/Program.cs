//Structs improvements
using Feature6;

Console.WriteLine("Paramter less struct is not available in c# 9");
Console.WriteLine("With operator in c# 10");
var rectangle=new Rectangle();
var newRectangle = rectangle with { Width = 30 }; //with operator
Console.WriteLine(newRectangle.Width); 
