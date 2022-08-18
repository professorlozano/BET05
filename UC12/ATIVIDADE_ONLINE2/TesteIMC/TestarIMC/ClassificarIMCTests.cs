using TesteIMC;

namespace TestarIMC
{
    //classe de testes que voce queira executar
    [TestClass]
    public class ClassificarIMCTests
    {
        //método de teste
        [TestMethod]
        //descrição do teste
        public void ClassificarIMC()
        {
            //arrange - organizar, preparar o teste
            double imc = 28;

            //act - agir - execução/chamada método
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //assert - comportamento esperado, comportamento obtido
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }
}
