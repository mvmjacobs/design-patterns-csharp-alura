using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDesconto
{
    public class CalculadorDeDesconto
    {
        public double CalcularDesconto(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoMaisDeCincoItens();
            IDesconto d2 = new DescontoValorMaiorQue500();

            d1.Proximo = d2;

            return d1.Calcular(orcamento);
        }
    }
}
