using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Abstract
{
    public class Designer : Employee
    {
        public override void Reajustment()
        {
            salary += 500;
        }
    }
}
