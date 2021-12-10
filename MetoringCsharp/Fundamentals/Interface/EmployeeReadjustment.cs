using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Interface
{
    public class EmployeeReadjustment : IReadjustment
    {
        public string name;
        public double salary;

        public void Readjustment()
        {
            salary = salary * 1.50;
        }
    }
}
