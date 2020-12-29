using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_9_Aula_123_Exercicio_Fixacao.Entidades
{
    class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product()
            {
            }

        public Product(string name, double price)
        {
            ProductName = name;
            ProductPrice = price;
        }
    }
}
