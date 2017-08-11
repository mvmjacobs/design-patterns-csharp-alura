using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
