using Punto3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(5,3);
            Console.WriteLine("El area es: {0}, y el perimetro es {1}",rectangulo.CalcularArea(),rectangulo.CalcularPerimetro());
        }
    }
}
