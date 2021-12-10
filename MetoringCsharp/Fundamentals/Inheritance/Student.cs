using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Inheritance
{
    public class Student : Person
    {
        public int Registration { get; set; }
        public Student(string name, string cpf, DateOnly birthdate, int registration) : base(name, cpf, birthdate)
        {
            Registration = registration;
        }

        public override string ToString()
        {
            return $"Aluno: {Name} \nCPF: {CPF} \nMatrícula: {Registration} \nData de nascimento: {BirthDate}";
        }

        public override double makeCopies(int amount)
        {
            return 0.07 * amount;
        }
    }
}
