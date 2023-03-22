using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Uge4_Fødselsdage
{
    internal class Person
    {
        public string Name { get; private init; }
        public int Age { get; private set; }
        public string Address { get; private init; }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public void fødselsdag()
        {
            Age++;
        }
    }


}
