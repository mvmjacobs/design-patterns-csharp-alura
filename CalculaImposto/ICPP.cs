using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    public class ICPP : ImpostoTemplate
    {
        public ICPP(IImposto outroImposto) : base(outroImposto) { }
        public ICPP() : base() { }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        public override bool UsaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
    }
}
