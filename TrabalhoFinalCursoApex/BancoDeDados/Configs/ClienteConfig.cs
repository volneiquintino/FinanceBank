using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrabalhoFinalCursoApex.Models;

namespace TrabalhoFinalCursoApex.BancoDeDados.Configs
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("CLIENTES");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Genero).IsRequired();
            builder.Property(x => x.DataNascimento).IsRequired();
            builder.Property(x => x.TelefoneCelular).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Rg).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Cpf).IsRequired().HasMaxLength(14);
            builder.Property(x => x.Rua).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Pais).IsRequired().HasMaxLength(200);
            
        }


    }
}

