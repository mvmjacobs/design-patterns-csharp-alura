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
            double valor = investimento.Calcular(conta);
            conta.Depositar(valor * 0.75);
            Console.WriteLine(conta.Saldo);
        }
    }
}
