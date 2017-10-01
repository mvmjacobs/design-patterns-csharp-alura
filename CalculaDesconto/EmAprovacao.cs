using System;

namespace CalculaDesconto
{
    public class EmAprovacao : IStatusOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.StatusAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.StatusAtual = new Reprovado();
        }
    }
}
