using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2.Entidades
{
    /// <summary>
    /// Clase Producto
    /// </summary>
    class Producto
    {
        /// <summary>
        /// Atributos privados de Producto(Nombre, Stock, Precio)
        /// </summary>
        private string nombre;
        private double precio;
        private int stock;

        /// <summary>
        /// Atributos publicos de Producto(Nombre, Stock, Precio)
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }
        /// <summary>
        /// Validacion, si stock o precio es negativo. igual a 0.
        /// </summary>
        public int Stock
        {
            get => stock;
            set
            {
                if (value < 0)
                {
                    stock = 0;
                }
                else
                {
                    stock = value;
                }
            }
        }
        public double Precio
        {
            get => precio;
            set
            {
                if (value < 0)
                {
                    precio = 0;
                }
                else
                {
                    precio = value;
                }
            }
        }
        /// <summary>
        /// Metodo constructor para producto, recibe nombre, stock y precio. Asigna los valores a los atributos correspondientes.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        public Producto(string nombre, int stock, double precio)
        {
            this.Nombre = nombre;
            this.Stock = stock;
            this.Precio = precio;
        }
        /// <summary>
        /// Enumera los datos del producto, mostrando su nombre, stock y precio.
        /// </summary>
        public void MostrarProducto()
        {
            Console.WriteLine($"Nombre: {this.Nombre} - Stock: {this.Stock} - Precio: {this.Precio}");
        }

        /// <summary>
        /// Metodo que recibe un nuevo valor de stock y lo asigna al atributo correspondiente.
        /// </summary>
        /// <param name="q"></param>
        /// <returns>nuevo valor de stock</returns>
        public int ActualizarStock(int q)
        {
            stock = q;
            return stock;
        }
    } 
}
