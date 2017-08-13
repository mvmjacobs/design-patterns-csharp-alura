using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoConta
{
    public class RespostaEmXML : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public void Responder(Conta conta, EFormato formato)
        {
            if (formato == EFormato.XML)
                Console.WriteLine(String.Format("<conta><titular>{0}</titular><saldo>{1}</saldo></conta>", conta.Titular, conta.Saldo));
            else
                OutraResposta.Responder(conta, formato);
;       }
    }
}
