using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Challenge.Rectangle
{
    public class RectangleExecute
    {
        public static void Execute()
        {

            Console.Write("Insira a Largura do Retângulo: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a Altura do Retângulo: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width: width, height: height);

            Console.WriteLine();
            Console.WriteLine($"A área do retângulo: {rectangle.Area(width: width, height: height)}");

            Console.WriteLine($"Periemtro do retângulo: {rectangle.Perimeter(width: width, height: height)}");

            Console.WriteLine($"A Diagonal do retângulo: {rectangle.Diagonal(width: width, height: height)}");
        }
    }
}
