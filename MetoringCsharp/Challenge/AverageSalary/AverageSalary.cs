using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Challenge.AverageSalary
{
    public class AverageSalary
    {
        public static void Execute()
        {
            bool programFinal= true;
            decimal totalSalary = 0;

            List<Employee> employees = new List<Employee>();


            while (programFinal)
            {
                Console.WriteLine("Quer adicionar um novo funcionário? \"S\" para CONTINUAR e \"N\" para SAIR");
                string isContinue = Console.ReadLine();

                if (isContinue.ToUpper().Equals("S"))
                {
                    Console.WriteLine("Insira o nome do funcionário: ");
                    string nameEmployee = Console.ReadLine();

                    Console.WriteLine($"Insira o salário do {nameEmployee}: ");
                    decimal salaryEmployee = Convert.ToDecimal(Console.ReadLine());

                    Employee employee = new Employee(name: nameEmployee, salary: salaryEmployee);

                    employees.Add(employee);
                }
                else if(isContinue.ToUpper().Equals("N"))
                {
                    programFinal = false;
                }
            }

            employees.ForEach(employee => {
                
                Console.WriteLine(employee);

                totalSalary += employee.Salary;
            });

            totalSalary = totalSalary / employees.Count;

            Console.WriteLine($"Média Salarial é de R$ {totalSalary.ToString("N2")}");

        }
    }
}
