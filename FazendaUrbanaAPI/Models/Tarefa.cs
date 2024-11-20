using FazendaUrbanaAPI.Models.Enums;
using System.Text.Json.Serialization;

namespace FazendaUrbanaAPI.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }
        public int? FuncionarioId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataLimite { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataConclusao { get; set; }
        public StatusTarefa Status { get; set; }
        public int Prioridade { get; set; }

        public virtual Funcionario? Funcionario { get; set; }
    }

}