using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDesconto
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcular(Orcamento orcamento)
        {
            if (Existe(orcamento, "LAPIS") && Existe(orcamento, "CANETA"))
                return orcamento.Valor * 0.05;

            return Proximo.Calcular(orcamento);
        }

        private bool Existe(Orcamento orcamento, string nomeDoItem)
        {
            return orcamento.Itens.FirstOrDefault(i => i.Nome == nomeDoItem) != null;
        }
    }
}
