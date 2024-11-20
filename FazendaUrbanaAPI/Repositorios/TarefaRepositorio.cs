using FazendaUrbanaAPI.Data;
using FazendaUrbanaAPI.Models;
using FazendaUrbanaAPI.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FazendaUrbanaAPI.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly SistemaTarefasDBContext _dbContext;
        public TarefaRepositorio(SistemaTarefasDBContext sistemaTarefasDBContext) 
        {
            _dbContext = sistemaTarefasDBContext;
        }
        public async Task<Tarefa> BuscarPorId(int id)
        {
            return await _dbContext.Tarefas
                .Include(x => x.Funcionario)
                .FirstOrDefaultAsync(x => x.TarefaId == id);
        }
            
        public async Task<List<Tarefa>> BuscarTodasTarefas()    
        {
            return await _dbContext.Tarefas
                .Include(x => x.Funcionario)
                .ToListAsync();
        }
        public async Task<Tarefa> Adicionar(Tarefa tarefa)
        {
            await _dbContext.Tarefas.AddAsync(tarefa);
            await _dbContext.SaveChangesAsync();

            return tarefa;
        }

        public async Task<Tarefa> Atualizar(Tarefa tarefa, int id)
        {
            Tarefa tarefaPorId = await BuscarPorId(id);

            if(tarefaPorId == null)
            {
                throw new Exception($"Funcionario por ID:{id} Não foi encontrado no banco de dados.");
            }

            tarefaPorId.Titulo = tarefa.Titulo;
            tarefaPorId.Descricao = tarefa.Descricao;
            tarefaPorId.DataLimite = tarefa.DataLimite;
            tarefaPorId.DataCriacao = tarefa.DataCriacao;
            tarefaPorId.DataConclusao = tarefa.DataConclusao;
            tarefaPorId.Status = tarefa.Status;
            tarefaPorId.Prioridade = tarefa.Prioridade;
            tarefaPorId.FuncionarioId = tarefa.FuncionarioId;

            _dbContext.Tarefas.Update(tarefaPorId);
            await _dbContext.SaveChangesAsync();

            return tarefaPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            Tarefa tarefaPorId = await BuscarPorId(id);

            if (tarefaPorId == null)
            {
                throw new Exception($"Tarefa por ID:{id} Não foi encontrado no banco de dados.");
            }

            _dbContext.Tarefas.Remove(tarefaPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
