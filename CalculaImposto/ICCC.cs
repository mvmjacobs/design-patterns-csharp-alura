using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    public class ICCC : Imposto
    {
        public ICCC(IImposto outroImposto) : base(outroImposto) { }
        public ICCC() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            double valorDoOutroImposto = CalculoDoOutroImposto(orcamento);
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.05 + valorDoOutroImposto;

            if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                return orcamento.Valor * 0.07 + valorDoOutroImposto;

            return orcamento.Valor * 0.08 + 30 + valorDoOutroImposto;
        }
    }
}
