using System;
using System.Collections.Generic;
using System.Text;
using Secao_9_Aula_120_Exercício_1.Entidades.Enums;

namespace Secao_9_Aula_120_Exercício_1.Entidades
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        
        // Declaração da composição. Associando a classe Worker à classe Departamento. Um trabalhador para um departamento

        public Departamento Departament { get; set; }

        // Associando a classe Worker à classe Contract. Um trabalhador para vários contratos. Necessário uma lista de contratos
        public List<Contract> Contracts { get; set; } = new List<Contract>();
        
        public Worker()
        {
        }
        public Worker(string name, double bsSalary, WorkerLevel level, Departamento dpto)
        {
            Name = name;
            BaseSalary = bsSalary;
            Level = level;
            Departament = dpto;
        }
        
        // Método para adicionar contratos à lista de contratos do trabalhador
        public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
        }

        // Método para remover contratos da lista de contratos do trabalhador
        public void RemContract(Contract contract)
        {
            Contracts.Remove(contract);
        }

        // Método para sumarizar os valores de contratos dentro do mês e ano especificado pelo usuário
        // Necessário percorrer a lista de contratos do trabalhador e somar o valor dos contratos que corresponderem ao especificado
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (Contract element in Contracts)
            {
                if (element.Date.Year == year && element.Date.Month == month)
                {
                    sum += element.TotalValue();
                }
            }
            return sum;
        }

    }
}
