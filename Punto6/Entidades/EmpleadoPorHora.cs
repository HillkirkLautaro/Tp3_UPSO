using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6.Entidades
{
    class EmpleadoPorHora : Empleado
    {
        public EmpleadoPorHora(int sueldo, int horasTrabajadas) : base(sueldo, horasTrabajadas)
        {
        }

        public int CalcularSueldo() {
            return sueldo * horasTrabajadas;
        }
    }
}
