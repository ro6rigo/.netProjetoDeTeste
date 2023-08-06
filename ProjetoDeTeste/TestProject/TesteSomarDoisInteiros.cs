using ProjetoDeTeste;

namespace TestProject
{
    public class TesteSomarDoisInteiros
    {
        [Fact]
        public void TesteCaminhoFeliz()
        {
            //Arrange
            int valorA = 2;
            int valorB = 3;
            int valorEsperado = 5;

            //Act
            int soma = Calculo.Somar(valorA, valorB);

            //Assert
            Assert.Equal(valorEsperado, soma);
        }
    }
}