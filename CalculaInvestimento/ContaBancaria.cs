using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
    }
}
