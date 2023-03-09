using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXUnit
{
    public class ClassificarIMCTest
    {
        [Fact] // Atributo que especifica que é um método de teste
        public void ClassificarIMC_RetornaResultado()
        {
            //Arrange - Preparação, organizar o teste
            double imc = 28;

            //Act - Ação, execução/chamada do método
            var resultado = Operacoes.ClassificarIMC(imc);

            //Assert - Verificacao, comportamento esperado, comportamento obtido
            Assert.Equal("Sobrepeso", resultado);
        }

        [Theory] // É utilizado pra quando o método abaixo vai ser executado varias vezes de acordo com os dados passados em cada InlineData
        [InlineData(28, "Sobrepeso")] // Para cada vez que ele for executado devemos adicionar um InlineData com os dados que serão passados nos parâmetros
        [InlineData(31, "Obesidade Grau I")] // Como estamos passando os valores dos atributos aqui, isso dispensa a parte do Arrange(Preparação)
        public void ClassificarIMC_RetornaResultado_ParaUmaListaDeValores(double imc, string resultadoEsperado)
        {
            //Act - Ação, execução/chamada do método
            var resultado = Operacoes.ClassificarIMC(imc);

            //Assert - Verificacao, comportamento esperado, comportamento obtido
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
