using System;

namespace Ejercicio1
{
    class Persona
    {
        // Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }

    class Program
    {
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