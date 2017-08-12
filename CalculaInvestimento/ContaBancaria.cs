using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }

        public ContaBancaria(double saldoInicial)
        {
            this.Saldo = saldoInicial;
        }
    }
}
