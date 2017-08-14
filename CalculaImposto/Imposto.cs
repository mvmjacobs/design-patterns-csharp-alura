using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    public abstract class Imposto : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
