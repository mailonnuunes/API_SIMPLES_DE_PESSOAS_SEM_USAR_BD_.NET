

using APIPessoas.Entidade;

namespace APIPessoas.Interfaces
{
    public interface IPessoaRepository
    {
        public IList<Pessoa> MostrarTodasPessoas();

        public Pessoa MostrarPessoaPorId(int id);

        public void CriarPessoa(Pessoa pessoa);

        public void EditarPessoa(Pessoa pessoa);

        public void ExcluirPessoa(int id);

    }
}
