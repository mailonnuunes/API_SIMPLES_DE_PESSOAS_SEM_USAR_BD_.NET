using APIPessoas.Entidade;
using APIPessoas.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [Controller]
    [Route("/Pessoas")]
    public class PessoaController : ControllerBase
    {
        private IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public IList<Pessoa> MotrarTodasPessoas()
        {
            return _pessoaRepository.MostrarTodasPessoas();

        }
        [HttpGet("{id}")]
        public Pessoa MostrarPessoaPorId(int id)
        {
            return _pessoaRepository.MostrarPessoaPorId(id);
        }
        [HttpPost]
        public IActionResult CriarPessoa(Pessoa pessoa)
        {
            _pessoaRepository.CriarPessoa(pessoa);
            return Ok("Pessoa criada com sucesso.");
        }
        [HttpPut]
        public IActionResult EditarPessoa(Pessoa pessoa) 
        {
            _pessoaRepository.EditarPessoa(pessoa);
            return Ok("Pessoa editada com sucesso.");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _pessoaRepository.ExcluirPessoa(id);
            return Ok("Pessoa deletada com sucesso.");
        }
    }
}
