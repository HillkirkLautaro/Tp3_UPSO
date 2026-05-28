using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto9.Entidades
{
    static class Conversor
    {
        public static double CelsiusAFahrenheit(double valor)
        {
            valor = (valor * 9 / 5) + 32;
            return valor;
        }
        public static double FahrenheitACelsius(double valor)
        {
            valor = (valor - 32) * 5 / 9;
            return valor;
        }
        public static double MillasAKilometros(double valor)
        {
            valor = valor * 1.60934;
            return valor;
        }
        public static double KilometrosAMillas(double valor)
        {
            valor = valor / 1.60934;
            return valor;
        }
    }
}
