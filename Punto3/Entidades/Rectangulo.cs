using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3.Entidades
{
    class Rectangulo
    {
        private double baseRectangulo;
        private double alturaRectangulo;

        

        public double AlturaRectangulo { get => alturaRectangulo; set => alturaRectangulo = value; }
        public double BaseRectangulo { get => baseRectangulo; set => baseRectangulo = value; }

        public Rectangulo()
        {
        }

        public Rectangulo(double baseRectangulo, double alturaRectangulo)
        {
            BaseRectangulo = baseRectangulo;
            AlturaRectangulo = alturaRectangulo;
        }

        public double CalcularArea()
        {
            return BaseRectangulo * AlturaRectangulo;
        }
        public double CalcularPerimetro()
        {
            return 2 * (BaseRectangulo + AlturaRectangulo);
        }
    }
}
