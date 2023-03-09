using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    [TestClass] // Atributo que especifica que é uma classe de teste
    public class CalculoIMCTest
    {
        [TestMethod] // Atributo que especifica que é um método de teste
        public void CalcularIMC()
        {
            //Arrange - Preparação, organizar o teste
            double peso = 110;
            double altura = 1.79;

            //Act - Ação, execução/chamada do método
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            //Assert - Verificacao, comportamento esperado, comportamento obtido
            Assert.AreEqual(34.33, resultadoIMC);
        }
    }
}
