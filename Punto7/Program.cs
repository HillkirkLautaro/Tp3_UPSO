using Punto7.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura triangulo = new Triangulo() { Base = 5, Altura = 10 };
            Figura rectangulo = new Rectangul() { Base = 5, Altura = 10 };
            Figura circulo = new Circulo() {Radio = 5 };
            Console.WriteLine("El area del circulo es : {0}-El area del triangulo es: {1}-El area del rectangulo es : {2}",circulo.CalcularArea(), triangulo.CalcularArea(), rectangulo.CalcularArea());
        }
    }
}
