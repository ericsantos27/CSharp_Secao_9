using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Secao_9_Aula_123_Exercicio_Fixacao.Entidades.Enums;

namespace Secao_9_Aula_123_Exercicio_Fixacao.Entidades
{
    class Order
    {
        public DateTime OrderTime { get; set; }
        public OrderStatus StatusOrder { get; set; }
        public List<OrderItem> ItOrder = new List<OrderItem>();
        public Customer CustOrder { get; set; }

        public Order(DateTime odTime, OrderStatus odStatus)
        {
            OrderTime = odTime;
            StatusOrder = odStatus;
        }

        public Order (DateTime odTime, OrderStatus odStatus, Customer odCust)
        {
            OrderTime = odTime;
            StatusOrder = odStatus;
            CustOrder = odCust;
        }

        public void AddItem(OrderItem iOrd)
        {
            ItOrder.Add(iOrd);
        }

        public void RemItem(OrderItem iOrd)
        {
            ItOrder.Remove(iOrd);
        }

        public double TotalOrder()
        {
            double sum = 0;
            foreach(OrderItem element in ItOrder)
            {
                sum += element.ItemPrice;
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder PrintOrder = new StringBuilder();
            PrintOrder.AppendLine("RESUMO DA ORDEM: ");
            PrintOrder.AppendLine("Data e hora da compra: " + OrderTime.ToString("dd/MM/yyyy HH:mm:ss"));
            PrintOrder.AppendLine("Status da ordem: " + StatusOrder);
            PrintOrder.AppendLine("Cliente: " + CustOrder);
            PrintOrder.AppendLine("Itens da ordem: ");
            foreach(OrderItem element in ItOrder)
            {
                PrintOrder.AppendLine(element.ToString());
            }
            PrintOrder.AppendLine("Valor total: " + TotalOrder().ToString("F2", CultureInfo.InvariantCulture));
            return PrintOrder.ToString();
        }
    }
}
