using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_9_Aula_115_Enumeracoes.Entidades.Enums
{
    enum OrderStatus : int
    {
        PendingPaym = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
