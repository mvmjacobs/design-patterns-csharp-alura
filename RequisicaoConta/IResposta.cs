using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoConta
{
    interface IResposta
    {
        IResposta Proxima { get; set; }
        void Responder(Conta conta, EFormato formato);
    }
}
