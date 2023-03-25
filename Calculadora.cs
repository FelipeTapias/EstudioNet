namespace PruebasNet
{
    public class Calculadora
    {
        public int _x;
        int _y;
        public Calculadora(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int Sumar()
        {
            return _x+_y;
        }

        public int Restar()
        {
            return _x - _y;
        }

        public int Multiplicar()
        {
            return _x * _y;
        }
    }
}
