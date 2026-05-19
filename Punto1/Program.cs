using System;
using System.Net;
using Tp3_UPSO.entidades;

namespace Ejercicio1
{

    internal static class Program
    {
        /// <summary>
        /// Metodo saludar
        /// </summary>
        /// <param name="persona"></param>
        /// <return>Retorna una frase con el nombre y la edad de la persona</return>
        static void Saludar(this Persona persona)
        {
            Console.WriteLine($"Hola, mi nombre es {persona.Nombre} y tengo {persona.Edad} años.");
        }

        /// <summary>
        /// Metodo principal del programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Instanciar objetos
            Persona persona1 = new Persona("Lautaro", 20);
            Persona persona2 = new Persona("Ana", 25);

            // Mostrar datos
            persona1.Saludar();
            persona2.Saludar();

            Console.ReadKey();
        }
    }
}