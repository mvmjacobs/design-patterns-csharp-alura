using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("Marcos", 0.01);

            ServidorDeResposta servidor = new ServidorDeResposta();

            servidor.SolicitarResposta(conta, EFormato.XML);

            Console.ReadKey();
        }
    }
}
