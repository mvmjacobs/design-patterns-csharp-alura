using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDesconto
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Calcular(Orcamento orcamento);
    }
}
