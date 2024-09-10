using AlunosAPI.Models;
using AlunosAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlunosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {

        private readonly PessoaRepository _pessoaRepository;

        public PessoaController(PessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        // GET: api/<PessoaController>
        [HttpGet]
        public async Task<IEnumerable<Pessoa>> Listar()
        {
            return await _pessoaRepository.ListarTodasPessoas();
        }

        // GET api/<PessoaController>/5
        [HttpGet("{id}")]
        public async Task<Pessoa> BuscarPorId(int id)
        {
            return await _pessoaRepository.BuscarPorId(id);
        }

        // POST api/<PessoaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PessoaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PessoaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _pessoaRepository.DeletarPorId(id);
            return Ok();
        }
    }

}
