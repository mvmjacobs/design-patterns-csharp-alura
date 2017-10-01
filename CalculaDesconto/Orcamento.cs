using System.Collections.Generic;

namespace CalculaDesconto
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public IStatusOrcamento StatusAtual { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.StatusAtual = new EmAprovacao();
        }

        public void AdicionarItem(Item item)
        {
            this.Itens.Add(item);
            this.Valor += item.Valor;
        }

        public void AplicaDescontoExtra()
        {
            this.StatusAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            this.StatusAtual.Aprova(this);
        }

        public void Finaliza()
        {
            this.StatusAtual.Finaliza(this);
        }

        public void Reprova()
        {
            this.StatusAtual.Reprova(this);
        }
    }
}
