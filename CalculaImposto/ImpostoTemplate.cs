using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    public abstract class ImpostoTemplate : Imposto
    {
        public ImpostoTemplate(IImposto outroImposto) : base(outroImposto) { }
        public ImpostoTemplate() : base() { }

        public abstract bool UsaMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);

        public override double Calcula(Orcamento orcamento)
        {
            if (UsaMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);

            return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
        }
    }
}
