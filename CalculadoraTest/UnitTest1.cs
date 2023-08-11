using calculadora;
using System;
using Xunit;

namespace CalculadoraTest
{
    public class UnitTest1
    {
        [Fact] // usados para m�todos de testes
        public void Somar_DoisDouble_RetomarDouble()
        {
            //Arrange - corpo
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;


            //Act - a��o
            var soma = Calculo.Somar(num1,num2);

            //Assert - se de bom ou ruim
            Assert.Equal(valorEsperado, soma);
        }

        [Fact(Skip = "Teste ainda n�o dispon�vel")]
        public void Test2()
        {

        }
    }
}
