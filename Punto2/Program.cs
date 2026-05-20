using System;
using Punto2.Entidades;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancio Producto
            Producto producto1 = new Producto("Manzana", -2, -5.5);
            producto1.MostrarProducto();
            producto1.ActualizarStock(2);
            producto1.MostrarProducto();

        }
    }
}
