using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6.Entidades
{
    class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(int sueldo, int horasTrabajadas) : base(sueldo, horasTrabajadas)
        {
        }
        public int CalcularSueldo()
        {
            return sueldo * horasTrabajadas;
        }
    }
}
