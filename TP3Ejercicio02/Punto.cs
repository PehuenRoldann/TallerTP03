using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_Figuras
{
    internal class Punto
    {
        //ATRIBUTOS
        private double iX;
        private double iY;

        //CONSTRUCTOR
        /// <summary>
        /// Crea un objeto de la clase Punto, solicitando las coordenadas en x e y como parámetros.
        /// </summary>
        /// <param name="iX">Coordenada en x</param>
        /// <param name="iY">Coordenada en y</param>
        public Punto(double iX, double iY)
        {
            this.iX = iX;
            this.iY = iY;
        }

        //PROPIEDADES
        public double X { get { return iX; } set { this.iX = value; } }

        public double Y { get { return iY; } set { this.iY = value; } }

        //MÉTODOS
        /// <summary>
        /// Calcula la distancia desde el punto a otro.
        /// </summary>
        /// <param name="pPunto">Punto al que se quiere calcular la distancia.</param>
        /// <returns> Distancia desde el punto actual.</returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            double rX = Math.Abs(iX - pPunto.X);//Distancia en X
            double rY = Math.Abs(iY - pPunto.Y);//Distancia en Y
            double distancia = Math.Sqrt(rX * rX + rY * rY);//Distancia entre los dos puntos

            return distancia;
        }
    }
}
