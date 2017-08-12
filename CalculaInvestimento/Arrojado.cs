using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    public class Arrojado : IInvestimento
    {
        public double Calcular(ContaBancaria conta)
        {
            int chance = new Random().Next(10);
            if (chance >= 0 && chance <= 1)
                return conta.Saldo * 0.05;

            if (chance >= 2 && chance <= 4)
                return conta.Saldo * 0.03;

            return conta.Saldo * 0.006;
        }
    }
}
