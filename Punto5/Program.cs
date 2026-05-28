using Punto5.Entidades;
using Punto5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto("Honda", 2);
            Auto auto = new Auto("Toyota", 4);
            Console.WriteLine($"Info moto:{moto.MostrarInformacion()} - info auto: {auto.MostrarInformacion()}");
            Circulo circulo = new Circulo();
            Rectangulo rectangulo = new Rectangulo();
            Triangulo triangulo = new Triangulo();
            ((IDibujable)circulo).Dibujar();
            ((IDibujable)rectangulo).Dibujar();
            ((IDibujable)triangulo).Dibujar();
        }
    }
}
