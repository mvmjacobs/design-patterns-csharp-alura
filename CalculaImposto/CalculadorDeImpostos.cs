using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }
    }
}
