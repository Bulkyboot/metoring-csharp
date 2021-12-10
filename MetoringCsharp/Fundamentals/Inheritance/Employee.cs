using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Inheritance
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public DateOnly DateAdmission { get; set; }
        public string Office { get; set; }
        public Employee(string name, string cpf, DateOnly birthdate, decimal salary, DateOnly dateAdmission, string office) : base(name, cpf, birthdate)
        {
            Salary = salary;
            DateAdmission = dateAdmission;
            Office = office;
        }

        public override string ToString()
        {
            return $"Funcionário: {Name} \nCPF: {CPF} \nData de Nascimento: {BirthDate} \nSálario: {Salary} \nData de Admissão: {DateAdmission} \nCargo: {Office}";
        }
    }
}
