namespace TrabalhoFinalCursoApex.Models
{
    public class ContaInvestimento
    {
        public int Id { get; set; }
        public string NumeroAgencia { get; set; }
        public string NumeroContaInvestimento { get; set; }
        public double Saldo { get; set; }
        public DateTime CriacaoConta { get; set; }
        public bool ContaAtiva { get; set; }

    }
}
