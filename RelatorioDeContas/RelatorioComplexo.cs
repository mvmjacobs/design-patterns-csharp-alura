using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioDeContas
{
    public class RelatorioComplexo : RelatorioTemplate
    {
        public override void Cabecalho()
        {
            Console.WriteLine("Caixa Economica Federal");
            Console.WriteLine("Rua Principal, 1 - +11 (11) 1111-1111");
        }

        public override void Principal(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine(String.Format("{0}", conta.Titular));
                Console.WriteLine(String.Format("{0}.{1}", conta.Agencia, conta.Numero));
                Console.WriteLine(String.Format("{0}", conta.Saldo));
            }
        }

        public override void Rodape()
        {
            Console.WriteLine("email@caixa.gov.br");
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
