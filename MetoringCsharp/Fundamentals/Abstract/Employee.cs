using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Abstract
{
    public abstract class Employee
    {
        public string name;
        public decimal salary;

        public abstract void Reajustment();

    }
}
