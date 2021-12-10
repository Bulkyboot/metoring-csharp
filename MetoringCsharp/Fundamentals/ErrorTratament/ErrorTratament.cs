using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.ErrorTratament
{
    public class ErrorTratament
    {
        
        public static void Execute()
        {
            int age;
            //int n;

            try
            {
               
                Console.WriteLine("Informe a sua idade: ");
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Sua idade é: {age}");
                //n = 123;
            }
            catch (Exception errorInformAge)
            {
                //Uso de viável local não atribuida
                //Console.WriteLine(n);
                
                Console.WriteLine($"Houve um erro, por favor informe uma idade válida, erro: {errorInformAge.Message}");
            }

            Console.ReadKey();
        }
    }
}
