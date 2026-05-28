using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6.Entidades
{
    class Empleado
    {
        public Empleado(int sueldo, int horasTrabajadas)
        {
            this.sueldo = sueldo;
            this.horasTrabajadas = horasTrabajadas;
        }

        public int sueldo { get; set; }
        public int horasTrabajadas { get; set; }

        public int CalcularSueldo(int a, int b) {
            a = sueldo;
            b = horasTrabajadas;
            return a * b;
        }
    }
}
