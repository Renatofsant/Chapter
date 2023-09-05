global using Xunit;
using Projeto_teste_operacoes;

namespace ElementoX
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            // Arrange ou Preparação

            double pNum = 3;
            double sNum = 2;
            double rNum = 5;

            // Act ou Ação

            var resultado = operacoes.Somar(pNum, sNum);

            // Assert ou Verificação

            // Assert.AreEqual(rNum, resultado); AreEqual vem lá do MsTest e no XUnit ele provavelmente não é.
            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        [InlineData(5, 2, 7)]
        [InlineData(4, 5, 9)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act ou Ação

            var resultado = operacoes.Somar(pNum, sNum);

            // Assert ou Verificação

            Assert.Equal(rNum, resultado);
        }
    }
}