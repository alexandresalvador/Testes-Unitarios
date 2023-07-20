namespace Programa
{
    public class Calculadora
    {
        public double Somar (double a, double b)
        {
          return a + b;
        }   
        public double Diminuir (double a, double b)
        {
          return a - b;
        }   
        public double Multiplicar (double a, double b)
        {
          return a * b;
        }   
        public double Dividir (double a, double b)
        {
          return (b == 0) ? 0 : (a / b);
        }   
    }
}