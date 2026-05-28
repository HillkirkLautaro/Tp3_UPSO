using Punto8.Entidades;
using Punto8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contrato contrato = new Contrato() {Letra = "La letra lolxd" };
            Factura factura = new Factura() { Precio = 1000 };
            Ticket ticket = new Ticket() { Precio = 1000 }
            ;
            ((IImprimible)contrato).Imprimir();

            ((IImprimible)ticket).Imprimir();

            ((IImprimible)factura).Imprimir();
        }
    }
}
