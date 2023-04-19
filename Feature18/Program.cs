// See https://aka.ms/new-console-template for more information
Console.WriteLine("C# 11 introduces the generic attributes");

var student = new Student();
student.HelloWorld();

class Student
{
    [TypeAttribute(typeof(string))]
    public string HelloWorld() => "Hello how are you........";
}



public class TypeAttribute : Attribute
{
    public TypeAttribute(Type t) { 
        ParamType = t; 
    }

    public Type ParamType { get; }
}

public class GenericAttribute<T> : Attribute { }
