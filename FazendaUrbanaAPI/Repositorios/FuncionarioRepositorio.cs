using FazendaUrbanaAPI.Data;
using FazendaUrbanaAPI.Models;
using FazendaUrbanaAPI.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FazendaUrbanaAPI.Repositorios
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly SistemaTarefasDBContext _dbContext;
        public FuncionarioRepositorio(SistemaTarefasDBContext sistemaTarefasDBContext) 
        {
            _dbContext = sistemaTarefasDBContext;
        }
        public async Task<Funcionario> BuscarPorId(int funcionarioId)
        {
            return await _dbContext.Funcionarios.FirstOrDefaultAsync(x => x.FuncionarioId == funcionarioId);
        }

        public async Task<List<Funcionario>> BuscarTodosFuncionarios()    
        {
            return await _dbContext.Funcionarios.ToListAsync();
        }
        public async Task<Funcionario> Adicionar(Funcionario funcionario)
        {
            await _dbContext.Funcionarios.AddAsync(funcionario);
            await _dbContext.SaveChangesAsync();

            return funcionario;
        }

        public async Task<Funcionario> Atualizar(Funcionario funcionario, int funcionarioId)
        {
            Funcionario funcionarioPorId = await BuscarPorId(funcionarioId);

            if(funcionarioPorId == null)
            {
                throw new Exception($"Funcionario por ID:{funcionarioId} Não foi encontrado no banco de dados.");
            }

            funcionarioPorId.Nome = funcionario.Nome;
            funcionarioPorId.CPF = funcionario.CPF;
            funcionarioPorId.DataNascimento = funcionario.DataNascimento;
            funcionarioPorId.Endereco = funcionario.Endereco;
            funcionarioPorId.Telefone = funcionario.Telefone;
            funcionarioPorId.Email = funcionario.Email;
            funcionarioPorId.Cargo = funcionario.Cargo;
            funcionarioPorId.Login = funcionario.Login;
            funcionarioPorId.Senha = funcionario.Senha;

            _dbContext.Funcionarios.Update(funcionarioPorId);
            await _dbContext.SaveChangesAsync();

            return funcionarioPorId;
        }

        public async Task<bool> Apagar(int funcionarioId)
        {
            Funcionario funcionarioPorId = await BuscarPorId(funcionarioId);

            if (funcionarioPorId == null)
            {
                throw new Exception($"Funcionario por ID:{funcionarioId} Não foi encontrado no banco de dados.");
            }

            _dbContext.Funcionarios.Remove(funcionarioPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
