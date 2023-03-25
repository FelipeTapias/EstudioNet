
using Xunit;
using PruebasNet;
namespace PruebasNet.test.CalculadoraTest
{
    public class CalculadoraTest
    {
        Calculadora calculadora1 = new(10, 5);

        [Fact]
        public void SumarTest()
        {
            int resultadoSuma = calculadora1.Sumar();
            Assert.Equal(15, resultadoSuma);
            Assert.Equal(10, calculadora1._x);
        }

        [Fact]
        public void RestarTest()
        {
            int resultadoResta = calculadora1.Restar();
            Assert.Equal(5, resultadoResta);
        }

        [Fact]
        public void MultiplicarTest()
        {
            int resultadoMultiplicar = calculadora1.Multiplicar();
            Assert.Equal(50, resultadoMultiplicar);
        }
    }
}
