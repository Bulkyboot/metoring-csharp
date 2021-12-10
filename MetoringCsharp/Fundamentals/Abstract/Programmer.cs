using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Abstract
{
    public class Programmer : Employee
    {
        public override void Reajustment()
        {
            salary += 1000;
        }

    }
}
