using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoConta
{
    public class ServidorDeResposta
    {
        public void SolicitarResposta(Conta conta, EFormato formato)
        {
            IResposta r1 = new RespostaEmXML();
            IResposta r2 = new RespostaEmCSV();
            IResposta r3 = new RespostaEmPorcentagem();

            r1.OutraResposta = r2;
            r2.OutraResposta = r3;

            r1.Responder(conta, formato);
        }
    }
}
