// See https://aka.ms/new-console-template for more information
Console.WriteLine("We can specify the name of a method parameter in an attribute on the parameter declaration or method.");

Console.WriteLine(nameof(System.Collections.Generic));  // output: Generic
Console.WriteLine(nameof(List<int>));  // output: List
Console.WriteLine(nameof(List<int>.Count));  // output: Count
Console.WriteLine(nameof(List<int>.Add));  // output: Add

var numbers = new List<int> { 1, 2, 3 };
Console.WriteLine(nameof(numbers));  // output: numbers
Console.WriteLine(nameof(numbers.Count));  // output: Count
Console.WriteLine(nameof(numbers.Add));  // output: Add

Console.WriteLine("Beginning with C# 11, you can use a nameof expression with a method parameter inside an attribute on a method or its parameter.");
public class MyAttr : Attribute
{
    private readonly string _paramName;

    public MyAttr(string paramName)
    {
        _paramName = paramName;
    }
}
public class MyClass
{
    [MyAttr(nameof(param))]
    public void Method(int param, [MyAttr(nameof(param))] int anotherParam)
    {
    }
}