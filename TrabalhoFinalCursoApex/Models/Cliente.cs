using System.Security.Cryptography;

namespace TrabalhoFinalCursoApex.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneFixo { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string EmpresaAtual { get; set; }
        public DateTime DataAdmissao { get; set; }
        public double SalarioAtual { get; set; }
        public ContaCorrente NumeroDaContaCorrente { get; set;}
        public ContaPoupanca NumeroDaContaPoupanca { get; set; }
        public ContaInvestimento NumeroDaContaInvestimento { get; set; }    





    }
}



