using Feature91;
using System;

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Improved definite assignment");
        Console.WriteLine("These examples generated warnings in previous versions of C#, but don't in C# 10");
        var c = new Employee();
        string representation = "N/A";
        if ((c != null && c.GetDependentValue(out object obj)) == true)
        {
            representation = obj.ToString(); // undesired error
        }

        // Or, using ?.
        if (c?.GetDependentValue(out object obj2) == true)
        {
            representation = obj2.ToString(); // undesired error
        }

        // Or, using ??
        if (c?.GetDependentValue(out object obj3) ?? false)
        {
            representation = obj3.ToString(); // undesired error
        }

    }
}


