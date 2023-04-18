using Feature91;
using System;

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Improved definite assignment");
        Console.WriteLine("warnings for definite assignment and null-state analysis are more accurate");
        var c = new Employee();
        string? representation = "N/A";
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


