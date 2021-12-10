using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateOnly BirthDate { get; set; }

        public Person(string name, string cpf, DateOnly birthdate)
        {
            Name = name;
            CPF = cpf;
            BirthDate = birthdate;
        }

        public virtual double makeCopies(int amount)
        {
            return 0.10 * amount;
        }
    }
}
