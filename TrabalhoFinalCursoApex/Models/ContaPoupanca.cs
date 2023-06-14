namespace TrabalhoFinalCursoApex.Models
{
    public class ContaPoupanca
    {
        public int Id { get; set; }
        public string NumeroAgencia { get; set; }
        public string NumeroContaPoupanca { get; set; }
        public double Saldo { get; set; }
        public DateTime CriacaoConta { get; set; }
        public bool ContaAtiva { get; set; }
    }
}
