using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    [TestClass] // Atributo que especifica que é uma classe de teste
    public class ClassificarIMCTest
    {
        [TestMethod] // Atributo que especifica que é um método de teste
        public void ClassificarIMC()
        {
            //Arrange - Preparação, organizar o teste
            double imc = 28;

            //Act - Ação, execução/chamada do método
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //Assert - Verificacao, comportamento esperado, comportamento obtido
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }
}
