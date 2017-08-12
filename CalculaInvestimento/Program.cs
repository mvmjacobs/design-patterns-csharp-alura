using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvestimento conservador = new Conservador();
            IInvestimento moderado = new Moderado();

            ContaBancaria conta = new ContaBancaria();
            conta.Depositar(500);

            RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();
            realizador.RealizaInvestimento(conta, conservador);
            realizador.RealizaInvestimento(conta, moderado);

            Console.ReadKey();
        }
    }
}
