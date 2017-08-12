using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    public class Conservador : IInvestimento
    {
        public double Calcular(ContaBancaria conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
