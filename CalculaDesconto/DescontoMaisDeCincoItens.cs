using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDesconto
{
    public class DescontoMaisDeCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcular(Orcamento orcamento)
        {
            // TODO: Aplicar a regra
            return 0;
        }
    }
}
