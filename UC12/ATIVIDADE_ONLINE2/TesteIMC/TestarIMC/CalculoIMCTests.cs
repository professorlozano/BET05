using TesteIMC;

namespace TestarIMC
{
    //classe de testes que voce queira executar
    [TestClass]
    public class CalculoIMCTests
    {
        //método do teste
        [TestMethod]
        //descrição do teste
        public void CalcularIMC()
        {
            //arrange - organizar, perparar o teste
            double peso = 110;
            double altura = 1.79;

            //act - agir - execução/chamada do método
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            //Assert - comportamento esperado, comportamento obtivo
            Assert.AreEqual(34.33, resultadoIMC);
            
        }
    }
    
}
