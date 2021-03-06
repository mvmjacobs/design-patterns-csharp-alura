﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDesconto
{
    public class CalculadorDeDesconto
    {
        public double CalcularDesconto(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoMaisDeCincoItens();
            IDesconto d2 = new DescontoValorMaiorQue500();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto ultimo = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = ultimo;

            return d1.Calcular(orcamento);
        }
    }
}
