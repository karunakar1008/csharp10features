using Feature5;
//Record structs are introduced in c# 10
//Records are value types: It checks the valus of the props not the just the reference
Console.WriteLine("Hello, World!");
var person1=new Person("karunakar");
var person2 = new Person("karunakar");

Console.WriteLine(person1==person2);