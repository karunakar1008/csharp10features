using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature11
{
    internal class Class1
    {
        static void Main()
        {
            var person = new Person("","");
        }
    }
    public class Person
    {
        public Person() { }

        [SetsRequiredMembers]
        public Person(string firstName, string lastName) =>
            (FirstName, LastName) = (firstName, lastName);

        public required string FirstName { get; init; }
        public required string LastName { get; init; }

        public int? Age { get; set; }
    }
}
