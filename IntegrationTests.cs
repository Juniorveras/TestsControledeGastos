using Xunit;
using ControleDeGastos.Models;
using ControleDeGastos.Services;


public class IntegrationTests

{
    [Fact]
    public void AddDespesa_ValidData_CreatesDespesa()
    {
        // Arrange
        Categoria categoria = new Categoria("Test Category", "This is a test category");
        Despesa despesa = new Despesa("Test Despesa", 10.99m, categoria);

        // Act
        DespesaService despesaService = new DespesaService();
        despesaService.AddDespesa(despesa);


        // Assert
        Assert.True(despesaService.GetDespesas().Any(d => d.Id == despesa.Id));
    }
}