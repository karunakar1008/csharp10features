namespace Feature5
{
    public struct Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }
    internal record class Person(string FirstName); //Record class are introduced in c# 10
    internal record struct Employee(string FirstName); //Record structs are introduced in c# 10
    
    
    //public class Employee
    //{
    //    private readonly string FirstName;
    //    public Employee(string firstname)
    //    {
    //        this.FirstName = firstname;
    //    }
    //}
}