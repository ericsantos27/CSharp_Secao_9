using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_9_Aula_123_Exercicio_Fixacao.Entidades
{
    class Customer
    {
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public DateTime CustBirDate { get; set; }

        public Customer()
        {
        }

        public Customer(string name, string email, DateTime birthDate)
        {
            CustName = name;
            CustEmail = email;
            CustBirDate = birthDate;
        }

        public override string ToString()
        {
            return "Cliente: " + CustName + "; Nascimento: " + CustBirDate + "; Email: " + CustEmail;
        }
    }
}
