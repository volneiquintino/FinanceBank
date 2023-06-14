using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrabalhoFinalCursoApex.Models;

namespace TrabalhoFinalCursoApex.BancoDeDados.Configs
{
    public class ContaInvestimentoConfig : IEntityTypeConfiguration<ContaInvestimento>
    {

        public void Configure(EntityTypeBuilder<ContaInvestimento> builder)
        {
            builder.ToTable("CONTA_INVESTIMENTO");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.NumeroAgencia).IsRequired().HasMaxLength(10);
            builder.Property(x => x.NumeroContaInvestimento).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Saldo).IsRequired();
            builder.Property(x => x.CriacaoConta).IsRequired();
            builder.Property(x => x.ContaAtiva).IsRequired();

        }
    }
}
