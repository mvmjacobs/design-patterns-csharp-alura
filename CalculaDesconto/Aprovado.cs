namespace CalculaDesconto
{
    public class Aprovado : IStatusOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }
    }
}
