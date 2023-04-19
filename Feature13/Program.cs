// See https://aka.ms/new-console-template for more information
Console.WriteLine("The text inside the { and } characters for a string interpolation can now span multiple lines");
Console.WriteLine("The text between the { and } markers is parsed as C#. Any legal C#, including newlines, is allowed");

int day = 2;
string welcomeMessage = $"hello today is {day}";
Console.WriteLine(welcomeMessage);

string season = $"Today is {day switch
{
    0 => "Monday",
    1 => "TuesDay",
    2 => "Wednesday",
    3 => "Thurseday",
    4 => "Friday",
    > 4 or <= -1 => "Weekend",
}}.";

Console.WriteLine(season);

// LINQ query in string interpolation 
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
string message = $"The reversed even values of {nameof(numbers)} are {
    string.Join(", ", numbers.Where(n => n % 2 == 0).Reverse())
    }.";

Console.WriteLine(message);
