using Xunit;

namespace ControleDeGastosTeste
{
    public class CategoriaTests
    {
        [Fact]
        public void Categoria_Constructor_ValidData_CreatesCategoria()
        {
            // Arrange
            string nome = "Test Category";
            string descricao = "This is a test category";

            // Act
            Categoria categoria = new Categoria(nome, descricao);

            // Assert
            Assert.NotNull(categoria);
            Assert.Equal(nome, categoria.Nome);
            Assert.Equal(descricao, categoria.Descricao);
        }


        [Fact]
        public void Categoria_Constructor_InvalidData_ThrowsArgumentException()
        {
            // Arrange
            string nome = null;
            string descricao = "This is a test category";
            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Categoria(nome, descricao));
        }
    }
}