using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Fundamentals.Inheritance
{
    public class InheritanceExecute
    {
        public static void Execute()
        {
            Student student = new Student(name: "Ruan", cpf: "062.856.754-05", birthdate: new DateOnly(1995, 11, 29), registration: 256389);
            Teacher teacher = new Teacher(name: "Rogerio", cpf: "075.689.741-05", birthdate: new DateOnly(1990, 12, 29), salary: 6000.00M, subjet: "Mentoria C#");
            Employee employee = new Employee(name: "Cristiano", cpf: "051.362.758-75", birthdate: new DateOnly(1989, 10, 11),
                salary: 5000.00M, dateAdmission: new DateOnly(2016, 02, 03), office: "Assistente de Contabil");

            Console.WriteLine(student);
            Console.WriteLine();

            Console.WriteLine(teacher);
            Console.WriteLine();

            Console.WriteLine(employee);

            Console.WriteLine();
            Console.WriteLine($"{student.Name} informe quantas copias quer tirar: ");
            int amountCopies = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Valor das {amountCopies} copias tiradas é de R${student.makeCopies(amountCopies).ToString("N2")}");

        }
    }
}
