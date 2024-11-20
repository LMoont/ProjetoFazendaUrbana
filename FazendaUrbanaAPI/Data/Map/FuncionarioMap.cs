using FazendaUrbanaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FazendaUrbanaAPI.Data.Map
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(x => x.FuncionarioId);

            builder.Property(x => x.Nome)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(x => x.CPF)
                   .IsRequired()
                   .HasMaxLength(14); // Ajuste para o formato de CPF (se necessário)

            builder.Property(x => x.DataNascimento)
                   .IsRequired();

            builder.Property(x => x.Endereco)
                   .HasMaxLength(255);

            builder.Property(x => x.Telefone)
                   .HasMaxLength(15); // Ajuste para formato padrão de telefone

            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(x => x.Cargo)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Login)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.Senha)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
