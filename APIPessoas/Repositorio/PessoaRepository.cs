using APIPessoas.Entidade;
using APIPessoas.Interfaces;

namespace APIPessoas.Repositorio
{
    public class PessoaRepository : IPessoaRepository
    {
        IList<Pessoa> pessoas = new List<Pessoa>();
        public IList<Pessoa> MostrarTodasPessoas()
        {
            return pessoas;
        }
        public Pessoa? MostrarPessoaPorId(int id)
        {
        return pessoas.FirstOrDefault(pessoa => pessoa.Id == id);

        }

        public void CriarPessoa(Pessoa pessoa)
        {
             pessoas.Add(pessoa);
        }

        public void EditarPessoa( Pessoa pessoa)
        {
          var pessoaEditar = MostrarPessoaPorId(pessoa.Id);
            pessoaEditar.Nome = pessoa.Nome;
            pessoaEditar.Sobrenome = pessoa.Sobrenome;
            pessoaEditar.Idade = pessoa.Idade;

        }

        public void ExcluirPessoa(int id)
        {

            var pessoaExcluida = MostrarPessoaPorId(id);
            pessoas.Remove(pessoaExcluida);
        }

  

    }
}
