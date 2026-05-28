using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Punto8.Interfaces;
using System.Threading.Tasks;

namespace Punto8.Entidades
{
    class Ticket : IImprimible
    { 
        public double Precio { get; set; }
        void IImprimible.Imprimir()
        {
            Console.WriteLine("Ticket impreso el precio es : {0}", Precio);
        }
    }
}
