using Microsoft.EntityFrameworkCore;
using TrabalhoFinalCursoApex.BancoDeDados.Configs;
using TrabalhoFinalCursoApex.Models;

namespace TrabalhoFinalCursoApex.BancoDeDados.Contexto
{
    public class Context : DbContext
    {
        public DbSet<Cliente> CLIENTES {get; set;}
        public DbSet<ContaCorrente> CONTA_CORRENTE { get; set; }
        public DbSet<ContaPoupanca> CONTA_POUPANCA { get; set; }
        public DbSet<ContaInvestimento> CONTA_INVESTIMENTO { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-42MV8LH\\SQLEXPRESS;Initial catalog=FINANCE_BANK;Trusted_connection=true;trustservercertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            //modelBuilder.ApplyConfiguration(new ContaCorrenteConfig());
            //modelBuilder.ApplyConfiguration(new ContaPoupancaConfig());
            //modelBuilder.ApplyConfiguration(new ContaInvestimentoConfig());
        }

    }
}
