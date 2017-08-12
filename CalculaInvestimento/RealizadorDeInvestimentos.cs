using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(ContaBancaria conta, IInvestimento investimento)
        {
            investimento.Investir(conta);
            Console.WriteLine(conta.Saldo);
        }
    }
}
