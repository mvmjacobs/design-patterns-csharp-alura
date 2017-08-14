using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    public abstract class Imposto : IImposto
    {
        protected IImposto OutroImposto { get; private set; }

        public Imposto(IImposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (this.OutroImposto == null)
                return 0;

            return this.OutroImposto.Calcula(orcamento);
        }
    }
}
