using Punto6.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoPorHora empleado0 = new EmpleadoPorHora(20,8);
            EmpleadoTiempoCompleto empleado1 = new EmpleadoTiempoCompleto(23,10);
            Console.WriteLine(empleado0.CalcularSueldo());
            Console.WriteLine(empleado1.CalcularSueldo());
        }
    }
}
