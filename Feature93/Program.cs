// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var myDate = new DateOnly(2023, 04, 25);
Console.WriteLine(myDate);
Console.WriteLine(myDate.ToLongDateString());

var today = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(today);
var oneyearFromToday = today.AddYears(1);
Console.WriteLine(oneyearFromToday);

var myTime = new TimeOnly(9, 0);
Console.WriteLine(myTime);

var startTime=new TimeOnly(10, 0);  var endtime=new TimeOnly(10, 30,25);

var diffTime=endtime- startTime;
Console.WriteLine(diffTime);
Console.WriteLine(endtime>startTime);

Console.WriteLine("C# 10 features");
Console.WriteLine("Know the process id and path");
Console.WriteLine(Environment.ProcessId);
Console.WriteLine( Environment.ProcessPath);
Console.ReadLine();
