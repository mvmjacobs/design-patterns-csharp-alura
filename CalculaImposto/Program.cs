﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto icms = new ICMS();
            IImposto iss = new ISS();
            IImposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.00);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, iccc);

            Console.ReadKey();
        }
    }
}
