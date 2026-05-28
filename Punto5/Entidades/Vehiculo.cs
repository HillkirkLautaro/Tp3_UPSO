using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5.Entidades
{
    class Vehiculo
    {
        public Vehiculo(string marca, int cantidadRuedas)
        {
            Marca = marca;
            CantidadRuedas = cantidadRuedas;
        }

        public string Marca { get; set; }
        public int CantidadRuedas { get; set; }
        public string MostrarInformacion()
        {
            return $"Marca: {Marca}, Cantidad de Ruedas: {CantidadRuedas}";
        }
    }
}
