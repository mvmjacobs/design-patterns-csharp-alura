using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioDeContas
{
    public abstract class RelatorioTemplate
    {
        public abstract void Cabecalho();
        public abstract void Rodape();
        public abstract void Principal(IList<Conta> contas);

        public void Imprime(IList<Conta> contas)
        {
            Cabecalho();
            Principal(contas);
            Rodape();
        }
    }
}
