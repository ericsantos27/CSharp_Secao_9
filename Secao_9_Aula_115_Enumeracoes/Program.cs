using System;
using Secao_9_Aula_115_Enumeracoes.Entidades;
using Secao_9_Aula_115_Enumeracoes.Entidades.Enums;

namespace Secao_9_Aula_115_Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOrder Order = new ClassOrder { Id = 1080, Time = DateTime.Now, Status = OrderStatus.PendingPaym } ;

            Console.WriteLine(Order);
        }
    }
}
