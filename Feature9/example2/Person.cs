using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature9.example2
{
    public class Person
    {
        public int PersonId { get; set; }
        public List<Relative> Relatives { get; set; }
        public List<PersonAddres> Addresses { get; set; }
    }
    public class PersonAddres
    {
        public string Permanent { get; set; }
        public string Temporary { get; set; }

    }
    public class Relative
    {
        public int RelativeId { get; set; }
        public string Name { get; set; }
        public string Relation { get; set; }
    }
}
