using FazendaUrbanaAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FazendaUrbanaAPI.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(t => t.TarefaId);  // Define a chave primária

            builder.Property(t => t.Titulo)    // Título da tarefa
                .IsRequired()                  // Título obrigatório
                .HasMaxLength(255);            // Tamanho máximo para o título

            builder.Property(t => t.Descricao) // Descrição da tarefa
                .HasMaxLength(500);            // Tamanho máximo para a descrição

            builder.Property(t => t.DataLimite) // Data limite da tarefa
                .IsRequired();                 // Data limite obrigatória

            builder.Property(t => t.DataCriacao) // Data de criação da tarefa
                .IsRequired();                 // Data de criação obrigatória

            builder.Property(t => t.DataConclusao) // Data de conclusão da tarefa
                .IsRequired(false);            // Data de conclusão não obrigatória

            builder.Property(t => t.Status)        // Status da tarefa (1, 2, 3...)
                .IsRequired();                  // Status obrigatório

            builder.Property(t => t.Prioridade)    // Prioridade da tarefa (1, 2, 3...)
                .IsRequired();                  // Prioridade obrigatória

            // Relacionamento com Funcionario
            builder.HasOne(t => t.Funcionario)
                .WithMany(f => f.Tarefas)  // Um Funcionario pode ter várias tarefas
                .HasForeignKey(t => t.FuncionarioId) // Relacionamento usando FuncionarioId
                .OnDelete(DeleteBehavior.Restrict);  // Impede a deleção de um funcionário com tarefas associada
        }
    }

}
