// See https://aka.ms/new-console-template for more information
Console.WriteLine("New LINQ methods in c#10");

IEnumerable<string> list = new List<string>() { "karuna","sreenu","vishnu","lahari","balu","lalith","latha","pushpa","swathi","chiti","abhi","nadiya","kishore" };
foreach (string[] chunk in list.Chunk(3))
{
	foreach (var item in chunk)
	{
        Console.WriteLine(item);
    }    
}
Console.ReadLine();
