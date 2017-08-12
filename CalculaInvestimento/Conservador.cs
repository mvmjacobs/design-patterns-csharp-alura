using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    public class Conservador : IInvestimento
    {
        public void Investir(ContaBancaria conta)
        {
            conta.Saldo += conta.Saldo * 0.008;
        }
    }
}
