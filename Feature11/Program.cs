// See https://aka.ms/new-console-template for more information
Console.WriteLine("Raw string literals");
string longMessage = """
    This is a long message.
    It has several lines.
        Some are indented
                more than others.
    Some should start at the first column.
    Some have "quoted text" in them.
    """;
Console.WriteLine(longMessage);

var Longitude = 10;
var Latitude = 30;

var location = $$"""
   You are at {{Longitude}}, {{Latitude}}
   """;
Console.WriteLine(location);