using FazendaUrbanaAPI.Models;

namespace FazendaUrbanaAPI.Repositorios.Interfaces
{
    public interface IFuncionarioRepositorio
    {
        Task<List<Funcionario>> BuscarTodosFuncionarios();
        Task<Funcionario> BuscarPorId(int FuncionarioId);
        Task<Funcionario> Adicionar(Funcionario funcionario);
        Task<Funcionario> Atualizar(Funcionario funcionario, int FuncionarioId);
        Task<bool> Apagar(int FuncionarioId);
    }
}
