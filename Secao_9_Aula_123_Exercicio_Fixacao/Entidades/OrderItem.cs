using System;
using System.Collections.Generic;
using System.Text;
using Secao_9_Aula_123_Exercicio_Fixacao.Entidades;

namespace Secao_9_Aula_123_Exercicio_Fixacao.Entidades
{
    class OrderItem
    {
        public int ItemQty { get; set; }
        public double ItemPrice { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem (int qty, double price, Product prd)
        {
            ItemQty = qty;
            ItemPrice = price;
            Product = prd;
        }

        public double SubTotal()
        {
            return ItemQty * ItemPrice;
        }

        public override string ToString()
        {
            return "Nome: " + Product.ProductName + "; Preço: $" + ItemPrice + "; Quantity: " + ItemQty + "; Subtotal: $" + SubTotal();
        }
    }
}
