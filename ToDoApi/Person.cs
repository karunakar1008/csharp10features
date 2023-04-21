namespace ToDoApi
{
    public class Person
    {
        public string Name = "default value";
        public string? Sex;
        public string Address = String.Empty;
        public bool Gender { get; set; }
        public string Description { get; set; }
        public Address PersonAddress { get; set; }
    }
    public class Address
    {
        public string City { get; set; }
        public string Area { get; set; }
    }
}
