using Punto5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5.Entidades
{
    class Circulo : IDibujable
    {
        void IDibujable.Dibujar()
        {
            Console.WriteLine("Dibujando un círculo...");
        }
    }
}
