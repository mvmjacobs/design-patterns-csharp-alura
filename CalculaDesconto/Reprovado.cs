using System;

namespace CalculaDesconto
{
    public class Reprovado : IStatusOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não pode receber desconto.");
        }
    }
}
