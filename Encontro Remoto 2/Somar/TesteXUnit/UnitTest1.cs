using Projeto_teste;

namespace TesteXUnit
{
    public class UnitTest1
    {
        [Fact] // Atributo que especifica que é um método de teste
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação, organizar o teste
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - Ação, execução/chamada do método
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificacao, comportamento esperado, comportamento obtido
            Assert.Equal(rNum, resultado);
        }

        [Theory] // É utilizado pra quando o método abaixo vai ser executado varias vezes de acordo com os dados passados em cada InlineData
        [InlineData(1, 1, 2)] // Para cada vez que ele for executado devemos adicionar um DataRow com os dados que serão passados nos parâmetros
        [InlineData(2, 2, 4)] // Como estamos passando os valores dos atributos aqui, isso dispensa a parte do Arrange(Preparação)
        [InlineData(2, 1, 2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - Ação, execução/chamada do método
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificacao, comportamento esperado, comportamento obtido
            Assert.Equal(rNum, resultado);
        }

    }
}