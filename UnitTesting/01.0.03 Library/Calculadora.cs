namespace _01._0._03_Library
{
    public class Calculadora
    {
        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
                return double.MinValue;
            else
                return dividendo / divisor;
        }
    }
}
