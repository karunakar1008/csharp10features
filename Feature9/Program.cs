using System.Runtime.CompilerServices;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("CallerArgumentExpression is used to get the expression used in condition");
        string[] excelColumns =new string[] {"Lastname"} ;

        // What you call
        //Assert(excelColumns.Length != 1);
        //// What gets compiled
        //Assert(excelColumns.Length != 1, "args.Length != 1");

        //// What you call
        //Assert(excelColumns.Length != 4);
        //Assert(excelColumns.Length != 4, "Excel does not have valid columns");

        // What gets compiled
        Assert(!excelColumns.Contains("Firstname"));
        Assert(!excelColumns.Contains("Firstname"), "First name column is mandatory");

        Console.ReadLine();
    }
    public static void Assert(bool condition, [CallerArgumentExpression("condition")] string conditionExpression = default)
    {
        if (condition)
            throw new Exception($"Condition failed: {conditionExpression}");
    }
}