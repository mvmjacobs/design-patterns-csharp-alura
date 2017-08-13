using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(0);
            orcamento.AdicionarItem(new Item("Teclado", 100));
            orcamento.AdicionarItem(new Item("Mouse", 100));
            orcamento.AdicionarItem(new Item("Monitor", 1000));
            orcamento.AdicionarItem(new Item("Placa de video", 1500));
            orcamento.AdicionarItem(new Item("HD", 500));

            CalculadorDeDesconto calculador = new CalculadorDeDesconto();
            double desconto = calculador.CalcularDesconto(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
