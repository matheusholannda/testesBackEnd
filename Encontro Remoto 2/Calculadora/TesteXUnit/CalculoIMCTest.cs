using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXUnit
{
    public class CalculoIMCTest
    {
        [Fact] // Atributo que especifica que é um método de teste
        public void CalcularIMC_RetornaResultado()
        {
            //Arrange - Preparação, organizar o teste
            double peso = 110;
            double altura = 1.79;

            //Act - Ação, execução/chamada do método
            var resultado = Operacoes.CalcularIMC(peso, altura);

            //Assert - Verificacao, comportamento esperado, comportamento obtido
            Assert.Equal(34.33, resultado);
        }

        [Theory] // É utilizado pra quando o método abaixo vai ser executado varias vezes de acordo com os dados passados em cada InlineData
        [InlineData(80, 1.79, 24.97)] // Para cada vez que ele for executado devemos adicionar um InlineData com os dados que serão passados nos parâmetros
        [InlineData(100, 1.79, 31.21)] // Como estamos passando os valores dos atributos aqui, isso dispensa a parte do Arrange(Preparação)
        public void CalcularIMC_RetornaResultado_ParaUmaListaDeValores(double peso, double altura, double resultadoEsperado)
        {
            //Act - Ação, execução/chamada do método
            var resultadoDoIMC = Operacoes.CalcularIMC(peso, altura);

            //Assert - Verificacao, comportamento esperado, comportamento obtido
            Assert.Equal(resultadoEsperado, resultadoDoIMC);
        }
    }
}
