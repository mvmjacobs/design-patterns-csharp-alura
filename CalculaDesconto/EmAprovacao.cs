namespace CalculaDesconto
{
    public class EmAprovacao : IStatusOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }
    }
}
