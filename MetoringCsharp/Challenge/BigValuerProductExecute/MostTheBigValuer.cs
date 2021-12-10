using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Challenge.BigValuerProductExecute
{
    public class MostTheBigValuer
    {
        public static void Execute()
        {
            double Computer = 0;
            double IPhoneX = 0;
            double Tablet = 0;

            Console.WriteLine("Enter the valuer of the computer");
            Computer = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the valuer of the IPhone X");
            IPhoneX = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Valuer of the Tablet");
            Tablet = double.Parse(Console.ReadLine());

            List<double> lista = new List<double> { Computer, IPhoneX, Tablet };
            double maiorValor = lista.Max();

            if (Computer.Equals(maiorValor))
            {
                Console.WriteLine("Computer, "+ maiorValor);
            }
            else if (IPhoneX.Equals(maiorValor))
            {
                Console.WriteLine("IPhone,"+ maiorValor);
            }
            else
            {
                Console.WriteLine("Tablet, "+ maiorValor);
            }
        }
    }
}
