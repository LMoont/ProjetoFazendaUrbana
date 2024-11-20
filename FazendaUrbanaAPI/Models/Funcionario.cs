using System.Text.Json.Serialization;

namespace FazendaUrbanaAPI.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Cargo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }

        // Lista de tarefas
        [JsonIgnore]
        public List<Tarefa>? Tarefas { get; set; } = new List<Tarefa>(); // Inicializando a lista para evitar null

    }

}