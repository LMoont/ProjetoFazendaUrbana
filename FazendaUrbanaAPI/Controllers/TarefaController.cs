using Microsoft.AspNetCore.Mvc;
using FazendaUrbanaAPI.Models;
using FazendaUrbanaAPI.Repositorios.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FazendaUrbanaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tarefa>>> ListarTodas()
        {
            List<Tarefa> tarefas = await _tarefaRepositorio.BuscarTodasTarefas();
            return Ok(tarefas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tarefa>> BuscarPorId(int id)
        {
            // Validação do ID
            if (id <= 0)
            {
                return BadRequest("O ID deve ser maior que zero.");
            }

            // Busca a tarefa no repositório
            var tarefa = await _tarefaRepositorio.BuscarPorId(id);

            // Verifica se a tarefa foi encontrada
            if (tarefa == null)
            {
                return NotFound($"Nenhuma tarefa encontrada com o ID {id}.");
            }

            // Retorna a tarefa encontrada
            return Ok(tarefa);
        }


        // POST api/<FazendaController>
        [HttpPost]
        public async Task<ActionResult<Tarefa>> Cadastrar([FromBody] Tarefa tarefa)
        {
            Tarefa novaTarefa = await _tarefaRepositorio.Adicionar(tarefa);
            return Ok(novaTarefa);
        }

        // PUT api/<FazendaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Tarefa>> Atualizar([FromBody] Tarefa tarefa, int id)
        {
            tarefa.TarefaId = id;
            Tarefa tarefa1 = await _tarefaRepositorio.Atualizar(tarefa, id);
            return Ok(tarefa1);
        }

        // DELETE api/<FazendaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tarefa>> Apagar(int id)
        {
            bool apagado = await _tarefaRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
