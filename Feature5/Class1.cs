namespace Feature5
{
    public struct Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }
    internal record class Person(string FirstName);
    internal record struct Employee(string FirstName); //Record structs are introduced in c# 10
}