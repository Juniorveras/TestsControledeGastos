
namespace ControleDeGastosTeste
{
    internal class Categoria
    {
        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public IEnumerable<char>? Nome { get; internal set; }
        public IEnumerable<char>? Descricao { get; internal set; }
    }
}