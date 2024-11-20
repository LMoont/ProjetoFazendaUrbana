using Microsoft.AspNetCore.Mvc;
using FazendaUrbanaAPI.Models;
using FazendaUrbanaAPI.Repositorios.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FazendaUrbanaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioController(IFuncionarioRepositorio funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Funcionario>>> BuscarTodosFuncionarios()
        {
            List<Funcionario> funcionarios = await _funcionarioRepositorio.BuscarTodosFuncionarios();
            return Ok(funcionarios);
        }
            
        [HttpGet("{id}")]
        public async Task<ActionResult<Funcionario>> BuscarPorId(int id)
        {
            Funcionario funcionarios = await _funcionarioRepositorio.BuscarPorId(id);
            return Ok(funcionarios);
        }

        // POST api/<FazendaController>
        [HttpPost]
        public async Task<ActionResult<Funcionario>> Cadastrar([FromBody] Funcionario funcionario)
        {
            Funcionario novoFuncionario = await _funcionarioRepositorio.Adicionar(funcionario);
            return Ok(novoFuncionario);
        }

        // PUT api/<FazendaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Funcionario>> Atualizar([FromBody] Funcionario funcionario, int id)
        {
            funcionario.FuncionarioId = id;
            Funcionario funcionario1 = await _funcionarioRepositorio.Atualizar(funcionario, id);
            return Ok(funcionario1);
        }

        // DELETE api/<FazendaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Funcionario>> Apagar(int id)
        {
            bool apagado = await _funcionarioRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
