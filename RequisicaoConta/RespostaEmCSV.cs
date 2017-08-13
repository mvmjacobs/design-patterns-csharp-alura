using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoConta
{
    public class RespostaEmCSV : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public void Responder(Conta conta, EFormato formato)
        {
            if (formato == EFormato.CSV)
                Console.WriteLine(String.Format("{0};{1}", conta.Titular, conta.Saldo));
            else
                OutraResposta.Responder(conta, formato);
        }
    }
}
