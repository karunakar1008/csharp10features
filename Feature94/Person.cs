using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature94
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class PersonViewModel
    {
        public List<Person> Persons { get; set; }
    }
    class Class2
    {
        static void Main()
        {
            PersonViewModel viewModel = new PersonViewModel { Persons = new List<Person>() };

            var oldest = viewModel.Persons.MaxBy(c => c.Age);
            var yungest = viewModel.Persons.MinBy(c => c.Age);
        }
    }
}
