using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    public class IKCV : ImpostoTemplate
    {
        public IKCV(IImposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        public override bool UsaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemComValorSuperiorA100(orcamento);
        }

        private bool TemItemComValorSuperiorA100(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                    return true;
            }
            return false;
        }
    }
}
