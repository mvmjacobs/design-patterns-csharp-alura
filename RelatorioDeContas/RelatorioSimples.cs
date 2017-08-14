using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioDeContas
{
    public class RelatorioSimples : RelatorioTemplate
    {
        public override void Cabecalho()
        {
            Console.WriteLine("Caixa Economica Federal");
        }

        public override void Principal(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine(String.Format("{0} - {1}", conta.Titular, conta.Saldo));
            }
        }

        public override void Rodape()
        {
            Console.WriteLine("+11 (11) 1111-1111");
        }
    }
}
