using MetoringCsharp.Challenge.TaxCoupon;
using ProjetoCSharp;
using System;
using MetoringCsharp.Challenge.BigValuerProductExecute;
using MetoringCsharp.Challenge.SellProducts;
using MetoringCsharp.Challenge.CheckOlderPerson;
using MetoringCsharp.Challenge.AverageSalary;
using MetoringCsharp.Challenge.Rectangle;
using MetoringCsharp.Fundamentals.Interface;
using MetoringCsharp.Fundamentals.Abstract;
using MetoringCsharp.Fundamentals.ErrorTratament;
using MetoringCsharp.Fundamentals.Inheritance;

namespace MetoringCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var center = new ExerciseCenter(new Dictionary<string, Action>() {

                {"Tax Coupon - Challenge", TaxCouponExecute.Execute},
                {"ArrayList - Collections", AbstractExecute.Execute },
                {"Maior valor Produto - Challenge", MostTheBigValuer.Execute},
                {"Soma Dos Produtos - Fundametals", ProductListInfoExecute.Execute },
                {"Verificar pessoa velha - Challenge", PersonExecute.Execute },
                {"Média Salarial - Challenge", AverageSalary.Execute },
                {"Retângulo - Challenge", RectangleExecute.Execute },
                {"Implement Interface - Fundamentals", InterfaceExecute.Execute },
                {"Implement Class Abstract - Fundamentals", AbstractExecute.Execute },
                {"Implement Error Tratament - Fundamentals", ErrorTratament.Execute },
                {"Implement Inheritance - Fundamentals", InheritanceExecute.Execute }



            });

            center.SelectAndRun();
            //var accountCorrent = new AccountCorrent("Gabriel", 0536, 412578, 1200.01);
            //var accountCorrent = new AccountCorrent();
            //AccountDeposit accountDeposit = new AccountDeposit();

            //accountDeposit.balance = 10.0;

            //Console.WriteLine(accountDeposit.balance);
            //Console.WriteLine(accountCorrent.balance);

            //accountCorrent.nameClient = "Gabriel";
            //accountCorrent.agency = 0536;
            //accountCorrent.account = 412578;
            //accountCorrent.balance = 1200.01;

            //Calculator calculator = new Calculator(23, 55);

            //Console.WriteLine(calculator.Result);
            
            //double sum = calculator.Sum(25, 45);
            //Console.WriteLine("Resultado da soma: " + sum);

            //double subtract = calculator.Subtract(25, 45);
            //Console.WriteLine("Resultado da subtração: " + subtract);

            //double multiplication = calculator.Multiplication(25, 45);
            //Console.WriteLine("Resultado da multiplicação: " + multiplication);

            //double division = calculator.Division(25, 45);
            //Console.WriteLine("Resultado da divisão: " + division);


            //calculator.ValueFirst = 15;
            //calculator.ValueSecond = 13;

            //Result = calculator.Sum();
            //Console.WriteLine(Result);



        }
    }
}
