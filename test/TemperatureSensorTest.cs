using PruebasNet.Clases;
using Xunit;

namespace PruebasNet.test
{
    public class TemperatureSensorTest
    {
        TemperatureSensor temperatureSensor = new();

        [Fact]
        public void ObtenerTemperature()
        {
            temperatureSensor.Initialize();
            int temperature = temperatureSensor.ReadCurrntTemperature();

            Assert.Equal(42, temperature);

        }

        [Fact]
        public void ObtenerError()
        {
            Exception exception = Assert.Throws<Exception>(() => temperatureSensor.ReadCurrntTemperature());

            Assert.Equal("Cannot read temerature before initializating.", exception.Message);
        }

        [Fact]
        public void SinRetorno()
        {
            Exception exception = Assert.Throws<Exception>(() => temperatureSensor.ShowTemperature());
        }
    }
}
