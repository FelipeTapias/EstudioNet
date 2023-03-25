namespace PruebasNet.Clases
{
    public class TemperatureSensor
    {
        bool _isInitialized;

        public void Initialize()
        {
            _isInitialized = true;
        } 

        public int ReadCurrntTemperature()
        {
            if(!_isInitialized)
            {
                throw new Exception("Cannot read temerature before initializating.");
            }

            return 42;
        }

        public string ShowTemperature()
        {
            try
            {
                Initialize();
                int temperature = ReadCurrntTemperature();
                Console.WriteLine($"La temperatura es: {temperature.ToString()}");
                return "hola";
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
