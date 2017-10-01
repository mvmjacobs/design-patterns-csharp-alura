using System;

namespace CalculaDesconto
{
    public class Finalizado : IStatusOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não pode receber desconto.");
        }
    }
}
