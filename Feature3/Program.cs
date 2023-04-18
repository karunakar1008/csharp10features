using Feature3;
using System.Text;

Console.WriteLine(ApiRoutes.GetByName);
Console.ReadKey();

var fullName = new StringBuilder("Bhogyari");
var LastName = "karunakar";

fullName.Append(LastName);
fullName.Append($"Hello {LastName}, how are you?");
Console.WriteLine(fullName);