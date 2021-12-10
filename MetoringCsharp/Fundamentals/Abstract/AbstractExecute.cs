using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Abstract
{
    public class AbstractExecute
    {
        public static void Execute()
        {
            Programmer programmer = new Programmer();
            Designer designer = new Designer();

            programmer.salary = 1100M;
            Console.WriteLine("Calculando reajuste programador");
            programmer.Reajustment();
            Console.WriteLine($"Novo salário: R$ {programmer.salary}");

            Console.WriteLine();

            designer.salary = 1100M;
            Console.WriteLine("Calculando reajuste designer");
            designer.Reajustment();
            Console.WriteLine($"Novo salário: R$ {designer.salary}");

            Console.ReadKey();
        }
    }
}
