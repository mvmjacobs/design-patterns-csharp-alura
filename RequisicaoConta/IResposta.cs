using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoConta
{
    public interface IResposta
    {
        IResposta OutraResposta { get; set; }
        void Responder(Conta conta, EFormato formato);
    }
}
