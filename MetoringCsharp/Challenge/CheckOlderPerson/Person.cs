using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Challenge.CheckOlderPerson
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {

        }

        public override string ToString()
        {
            return $"{Name} tem {Age} anos";
        }

        public bool containsPerson(string name)
        {            
            if(Name.ToLower() == name.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
