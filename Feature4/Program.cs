// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lambda improvements");
Console.WriteLine("Type inrefence is not supported in c# 9");

//Func<string> helloworld = () => "hellow world"; //

var helloWorld = () => "Hello Karuna";
var getId = () => 400;

var parse = (string s) => int.Parse(s);

Console.WriteLine(helloWorld());
Console.ReadKey();
