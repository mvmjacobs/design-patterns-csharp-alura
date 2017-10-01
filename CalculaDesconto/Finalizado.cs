using System;

namespace CalculaDesconto
{
    public class Finalizado : IStatusOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não pode receber desconto.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta finalizado");
        }
    }
}
