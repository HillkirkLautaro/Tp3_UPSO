using Punto4.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBanco cuenta = new CuentaBanco();
            cuenta.Depositar(100);
            cuenta.Retirar(300);
            cuenta.Retirar(50);
            Console.WriteLine("Saldo final: " + cuenta.Saldo);
            Console.ReadKey();

        }
    }
}
