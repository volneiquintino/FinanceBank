namespace TrabalhoFinalCursoApex.Models
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public string NumeroAgencia { get; set; }
        public string NumeroContaCorrente { get; set; }
        public double Saldo { get; set; }
        public DateTime CriacaoConta { get; set; }
        public bool ContaAtiva { get; set; }

    }
}
