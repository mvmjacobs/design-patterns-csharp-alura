using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    public class Moderado : IInvestimento
    {
        public void Investir(ContaBancaria conta)
        {
            double valor = conta.Saldo * (new Random().Next(101) > 50 ? 0.025 : 0.007);
            conta.Saldo += valor;
        }
    }
}
