using System;
using System.Collections.Generic;
using Secao_9_Aula_115_Enumeracoes.Entidades.Enums;

namespace Secao_9_Aula_115_Enumeracoes.Entidades
{
    class ClassOrder
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Pedido: " + Id + "; Data e hora: " + Time + "; Status: " + Status;
        }
    }
}
