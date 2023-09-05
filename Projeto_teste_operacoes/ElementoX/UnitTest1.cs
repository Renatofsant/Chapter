global using Xunit;
using Projeto_teste_operacoes;

namespace ElementoX
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            // Arrange ou Prepara��o

            double pNum = 3;
            double sNum = 2;
            double rNum = 5;

            // Act ou A��o

            var resultado = operacoes.Somar(pNum, sNum);

            // Assert ou Verifica��o

            // Assert.AreEqual(rNum, resultado); AreEqual vem l� do MsTest e no XUnit ele provavelmente n�o �.
            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        [InlineData(5, 2, 7)]
        [InlineData(4, 5, 9)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act ou A��o

            var resultado = operacoes.Somar(pNum, sNum);

            // Assert ou Verifica��o

            Assert.Equal(rNum, resultado);
        }
    }
}