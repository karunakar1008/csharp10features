using System.Diagnostics.CodeAnalysis;

namespace Feature12
{
    public class Person
    {
        public Person() { }

        [SetsRequiredMembers]
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; init; }
        public required string Surname { get; init; }
    }
}
