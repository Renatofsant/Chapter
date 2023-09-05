global using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_teste_operacoes;
using System;

namespace TesteMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            // Arrange ou Preparação

            double pNum = 3;
            double sNum = 2;
            double rNum = 5;


            // Act ou Ação

            var resultado = operacoes.Somar(pNum, sNum);



            // Assert ou Verificação

            Assert.AreEqual(rNum, resultado);

        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 3, 5)]
        [DataRow(4, 3, 7)]
        [DataRow(6, 2, 8)]
        [DataRow(2, 8, 10)]
        [DataRow(3, 5, 8)]
        [DataRow(8, 5, 13)]


        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act ou Ação

            var resultado = operacoes.Somar(pNum, sNum);

            // Assert ou Verificação

            Assert.AreEqual(rNum, resultado);
        }

       
    }
}