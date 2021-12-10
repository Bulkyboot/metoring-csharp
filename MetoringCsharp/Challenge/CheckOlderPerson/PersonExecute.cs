using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Challenge.CheckOlderPerson
{
    public class PersonExecute
    {
        public static void Execute()
        {
            bool programFinal = true;

            List<Person> personList = new List<Person>();
            

            do
            {
                Console.WriteLine("Quer inserir uma pessoa? \"Sim\" para CONTINUAR e \"Exit\" para SAIR");
                string programContinue = Console.ReadLine();
                Console.WriteLine();

                if (programContinue.ToLower() == "sim")
                {
                    Console.WriteLine("Insira o nome da pessoa: ");
                    string namePerson = Console.ReadLine();

                    Console.WriteLine($"Insira a idade da {namePerson}: ");
                    int agePerson = Convert.ToInt32(Console.ReadLine());

                    Person person = new Person(name: namePerson, age: agePerson);

                    personList.Add(person);
                } 
                else if(programContinue.ToUpper() == "EXIT")
                {
                    programFinal = false;
                }
                
            }
            while(programFinal);

            Console.WriteLine();
            
            personList.ForEach(person =>
            {
                Console.WriteLine(person);
            });
            Console.WriteLine();

            Console.WriteLine("Quer fazer alguma consulta? Caso queira, escolha uma das seguintes opções\n" +
                "1 - Consultar Pessoa mais velha com for\n" +
                "2 - Consultar Pessoa mais velha com Compare\n" +
                "3 - Para SAIR");
            string opcao = Console.ReadLine();

            while (opcao != "3")
            {
                switch (opcao)
                {
                    case "1":
                        for (int i = 0; i < personList.Count; i++)
                        {
                            for(int j = 0; j < personList.Count; j++)
                            {
                                if (personList[i].Age > personList[j].Age)
                                {
                                    Console.WriteLine($"{personList[i].Name} é mais velha que {personList[j].Name}");
                                }
                                else if (personList[i].Age < personList[j].Age)
                                {
                                    Console.WriteLine($"{personList[j].Name} é mais velha que {personList[i].Name}");
                                }
                                else if(personList[i].Name != personList[j].Name)
                                {
                                    Console.WriteLine($"{personList[i].Name} tem a mesma idade {personList[j].Name}");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "2":
                        personList.ForEach(person =>
                        {
                            Console.WriteLine(person);
                            Console.WriteLine();
                        });

                        int indexFirst = -1, indexSecond = -1;
                        
                        Console.WriteLine("Digite nome da primeira pessoa: ");
                        string nameFirst = Console.ReadLine();


                        Console.WriteLine("Digite nome da segunda pessoa: ");
                        string nameSecond = Console.ReadLine();
                        Console.WriteLine();

                        for(int index = 0; index < personList.Count; index++)
                        {
                            if (personList[index].containsPerson(nameFirst))
                            {
                                indexFirst = index;
                            }
                        }

                        personList.ForEach(person =>
                        {
                            if (person.containsPerson(nameFirst))
                            {
                                indexFirst = personList.IndexOf(person);
                            }
                        });

                        for (int index = 0; index < personList.Count; index++)
                        {
                            if (personList[index].containsPerson(nameSecond))
                            {
                                indexSecond = index;
                            }
                        }

                        if (indexFirst != -1 && indexSecond != -1)
                        {
                            if(personList[indexFirst].Age > personList[indexSecond].Age)
                            {
                                Console.WriteLine($"{personList[indexFirst].Name} é mais velho que {personList[indexSecond].Name}\n");
                            }
                            else if(personList[indexFirst].Age < personList[indexSecond].Age)
                            {
                                Console.WriteLine($"{personList[indexSecond].Name} é mais velho que {personList[indexFirst].Name}\n");
                            }
                            else
                            {
                                Console.WriteLine($"{personList[indexSecond].Name} tem a mesma idade de {personList[indexFirst].Name}\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nomes incorretos ou não existe na lista\n");
                        }
                        break;
                }

                Console.WriteLine("Quer fazer alguma consulta? Caso queira, escolha uma das seguintes opções\n" +
                "1 - Consultar Pessoa mais velha com for\n" +
                "2 - Consultar Pessoa mais velha com Compare\n" +
                "3 - Para SAIR");
                opcao = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Programa finalizado...");
        }
    }
}
