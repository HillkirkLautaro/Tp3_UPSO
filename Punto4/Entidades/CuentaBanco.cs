using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4.Entidades
{
    internal class CuentaBanco
    {
        private double saldo;
        public double Saldo { get => saldo; }

        public double Depositar(double nuevoSaldo) { saldo += nuevoSaldo; return (double)saldo; }
        public double Retirar(double retyro) { 
            if (retyro > saldo) { Console.WriteLine("Retiro mayor que saldo");}
            else {
                saldo -= retyro;
            }
            return (double) saldo;
        }
        public CuentaBanco()
        {
            saldo = 199;
        }
    }
}
