using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature9
{
    public class Demo
    {
        public static void Main()
        {
            Person p = new Person() { 
                Addresses = new List<PersonAddres>{ new PersonAddres { Permanent = "#1,bangalore" } },
            Relatives=new List<Relative> { new Relative { RelativeId = 1,Relation ="Brother",Name="Sreenu"} }
            };
            DisplayInfo(p);
            Console.ReadLine();
        }
        public static void DisplayInfo(Person person)
        {
            //var addresses = person.NotNull().Addresses;
            var aadharAddress = person.NotNull().Addresses.NotNull("Apply for aadhar");
            var relatives = person.Relatives.NotNull("Relatives should not be null else person is an orphan");
        }
    }
}
