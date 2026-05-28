using Punto8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto8.Entidades
{
    class Factura : IImprimible
    {
        public double Precio { get; set; }
        void IImprimible.Imprimir()
        {
            Console.WriteLine("Factura impresa el precio es : {0}", Precio);
        }
    }
}
