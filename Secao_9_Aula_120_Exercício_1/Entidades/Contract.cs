using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_9_Aula_120_Exercício_1.Entidades
{
    class Contract
    {
        public DateTime Date { get; set; }
        public double VlPerHour { get; set; }
        public int Hours { get; set; }

        public Contract()
        {
        }
        public Contract (DateTime date, double vlHour, int hours)
        {
            Date = date;
            VlPerHour = vlHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return Hours * VlPerHour;
        }

    }
}
