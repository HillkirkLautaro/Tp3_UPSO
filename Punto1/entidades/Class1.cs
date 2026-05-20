using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_UPSO.entidades
{
    /// <summary>
    /// Crear la clase persona con los atributos nombre y edad.
    /// </summary>
    class Persona
    {
        /// <summary>
        /// Valores privados de nombre y edad.
        /// </summary>
        private string nombre;
        private int edad;
        /// <summary>
        /// Valores publicos de nombre y edad.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        /// <summary>
        /// Crear el constructor de la clase persona que reciba como parámetros el nombre y la edad.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
        /// <summary>
        /// Metodo saludar
        /// </summary>
        /// <param name="persona"></param>
        /// <return>Retorna una frase con el nombre y la edad de la persona</return>
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }
}
