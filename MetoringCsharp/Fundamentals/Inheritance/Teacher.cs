using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Inheritance
{
    public class Teacher : Person
    {
        public decimal Salary { get; set; }
        public string Subjet { get; set; }
        public Teacher(string name, string cpf, DateOnly birthdate, decimal salary, string subjet) : base(name, cpf, birthdate)
        {            
            Salary = salary;
            Subjet = subjet;
        }

        public override string ToString()
        {
            return $"Professor: {Name} \nCPF: {CPF} \nData de Nascimento: {BirthDate} \nSálario: {Salary} \nDisciplina: {Subjet}";
        }
    }
}
