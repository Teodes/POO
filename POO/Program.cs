using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();
            Console.WriteLine(obj.Convierte(50));

            obj.CambioValorEuro(15);

            test test = new test();
            test.X = 12;
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void CambioValorEuro(double nuevoValor)
        {
            euro = nuevoValor;
        }
    }

    public class test
    {
        private int x = 0;
        private double y = 0;
        private string z = "Puto";

        public string Z
        {
            get => z;
            set => z = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public int X
        {
            get => x;
            set => x = value;
        }
    }

    class Circulo
    {
        //Campos de clase.
        private const double Pi = 3.1416;

        //Método de clase.
        public double CalculoArea(int radio)
        {
            return Pi * radio * radio;
        }
    }
}