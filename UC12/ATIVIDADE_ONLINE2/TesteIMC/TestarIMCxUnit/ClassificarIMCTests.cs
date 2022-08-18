using TesteIMC;

namespace TestarIMCxUnit
{
    public class ClassificarIMCTests
    {
        //método de teste
        [Fact]
        //descricao do teste

        public void ClassificarIMC_RetornaResultado()
        {
            //arrange - organizar, preparar o teste
            double imc = 28;

            //act - agir - execução/chamada do método
            var resultado = Operacoes.ClassificarIMC(imc);

            //Assert - comportamento esperado, comportamento obtido
            Assert.Equal("Sobrepeso", resultado);
        }

        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31,"Obesidade Grau I")]

        public void ClassificarIMC_RetornaResultado_ParaUmaListaDeValores(double primeiroNumero, string resultadoEsperado)
        {
            var resultadoDoIMC = Operacoes.ClassificarIMC(primeiroNumero);
            Assert.Equal(resultadoEsperado, resultadoDoIMC);
        }
    }
}
