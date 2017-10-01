using System;

namespace CalculaDesconto
{
    public class Reprovado : IStatusOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não pode receber desconto.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está reprovado e não pode ser aprovado novamente.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.StatusAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta reprovado");
        }
    }
}
