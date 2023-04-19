// See https://aka.ms/new-console-template for more information
Console.WriteLine("Auto-default struct");
Console.WriteLine("All fields of a struct type are initialized to their default value");
var person=new Person();
Console.WriteLine(person.Age);
Console.WriteLine(person.HasPassport);

struct Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public bool HasPassport { get; set; }
}
