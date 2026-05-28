using Punto9.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.FahrenheitACelsius(10));
            Console.WriteLine(Conversor.CelsiusAFahrenheit(10));
            Console.WriteLine(Conversor.MillasAKilometros(10));
            Console.WriteLine(Conversor.KilometrosAMillas(10));
        }
    }
}
