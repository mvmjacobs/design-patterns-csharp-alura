using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    public class IHIT : ImpostoTemplate
    {
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        public override bool UsaMaximaTaxacao(Orcamento orcamento)
        {
            IList<string> lst = new List<string>();
            foreach(var item in orcamento.Itens)
            {
                if (lst.Contains(item.Nome))
                    return true;
                lst.Add(item.Nome);
            }
            return false;
        }
    }
}
