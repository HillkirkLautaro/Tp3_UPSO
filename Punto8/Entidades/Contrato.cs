using Punto8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto8.Entidades
{
    class Contrato : IImprimible
    {
        public string Letra { get; set; }
        void IImprimible.Imprimir()
        {
            Console.WriteLine("Contrato impreso la letra es : {0}", Letra);
        }
    }
}
