using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrabalhoFinalCursoApex.Models;

namespace TrabalhoFinalCursoApex.BancoDeDados.Configs
{
    public class ContaPoupancaConfig : IEntityTypeConfiguration<ContaPoupanca>
    {

        public void Configure(EntityTypeBuilder<ContaPoupanca> builder)
        {
            builder.ToTable("CONTA_POUPANCA");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.NumeroAgencia).IsRequired().HasMaxLength(10);
            builder.Property(x => x.NumeroContaPoupanca).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Saldo).IsRequired();
            builder.Property(x => x.CriacaoConta).IsRequired();
            builder.Property(x => x.ContaAtiva).IsRequired();

        }
    }
}
