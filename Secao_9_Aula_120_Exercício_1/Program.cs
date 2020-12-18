using System;
using Secao_9_Aula_120_Exercício_1.Entidades;
using Secao_9_Aula_120_Exercício_1.Entidades.Enums;

namespace Secao_9_Aula_120_Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do trabalhador");
            Console.Write("Departamento: ");
            string wkDpto = Console.ReadLine();
            Console.Write("Nome: ");
            string wkName = Console.ReadLine();
            Console.Write("Nível: ");
            WorkerLevel wkLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            double wkSalary = double.Parse(Console.ReadLine());

            Departamento dpto = new Departamento(wkDpto);
            Worker wkEmployee = new Worker(wkName, wkSalary, wkLevel, dpto);

            Console.Write("Número de contratos: ");
            int numContracts = int.Parse(Console.ReadLine());
            for(int i = 1; i <= numContracts; i++)
            {
                Console.WriteLine("Dados do contrato {0}: ", i);
                Console.Write("Data do contrato (DD/MM/YYYY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor hora: ");
                double hourValue = double.Parse(Console.ReadLine());
                Console.Write("Horas contratadas: ");
                int hourContract = int.Parse(Console.ReadLine());

                Contract wkContract = new Contract(dateContract, hourValue, hourContract);
                wkEmployee.AddContract(wkContract);
                Console.WriteLine();
            }

            Console.Write("Mês e ano do contrato para receita: ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3, 4));

            Console.WriteLine("Trabalhador: {0}", wkEmployee.Name);
            Console.WriteLine("Departamento: {0}", wkEmployee.Departament.Name);
            Console.WriteLine("Renda para o período {0}: {1:F2}", monthAndYear, wkEmployee.Income(year, month));

        }
    }
}
