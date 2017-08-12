using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    public class Moderado : IInvestimento
    {
        public double Calcular(ContaBancaria conta)
        {
            if (new Random().Next(2) == 0)
                return conta.Saldo * 0.025;
            return conta.Saldo * 0.007;
        }
    }
}
