using System;
using Secao_9_Aula_123_Exercicio_Fixacao.Entidades;
using Secao_9_Aula_123_Exercicio_Fixacao.Entidades.Enums;

namespace Secao_9_Aula_123_Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do cliente: ");
            Console.Write("Nome: ");
            string nameCust = Console.ReadLine();
            Console.Write("Email: ");
            string emailCust = Console.ReadLine();
            Console.Write("Data de nascimento (DD/MM/AAAA): ");
            DateTime dtCust = DateTime.Parse(Console.ReadLine());

            Customer custData = new Customer(nameCust, emailCust, dtCust);
            Console.WriteLine();
            
            Console.WriteLine("Dados da ordem: ");
            Console.Write("Status: ");
            OrderStatus odStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Order purchOrder = new Order(DateTime.Now, odStatus, custData);
            Console.WriteLine();

            Console.Write("Número de itens para a ordem: ");
            int qtyItem = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < qtyItem; i++)
            {
                Console.WriteLine("Dados do item {0}: ", i + 1);
                Console.Write("Produto: ");
                string prdName = Console.ReadLine();
                Console.Write("Preço: ");
                double prdPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int prdQty = int.Parse(Console.ReadLine());
                Product productOrder = new Product(prdName, prdPrice);
                OrderItem itemOrder = new OrderItem(prdQty, prdPrice, productOrder);
                purchOrder.AddItem(itemOrder);
                Console.WriteLine();
            }

            Console.WriteLine(purchOrder);
        }
    }
}
