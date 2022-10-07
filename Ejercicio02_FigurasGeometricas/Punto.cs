using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_FigurasGeometricas
{
    internal class Punto
    {
        //ATRIBUTOS
        private double iX;
        private double iY;

        //CONSTRUCTOR
        /// <summary>
        /// Crea un nuevo objeto de la clase punto piediendo como parámetros <br></br>
        /// las coordenadas en x e y.
        /// </summary>
        /// <param name="iX">Coordenada en x.</param>
        /// <param name="iY">Coordenada en y.</param>
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
        /// Calcula la distancia del punto a otro punto pasado como parámetro.
        /// </summary>
        /// <param name="pPunto">Otro punto.</param>
        /// <returns>Distancia entre los puntos.</returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            double rX = Math.Abs(iX - pPunto.X);//Distancia en X
            double rY = Math.Abs(iY - pPunto.Y);//Distancia en Y
            double distancia = Math.Sqrt(rX * rX + rY * rY);//Distancia entre los dos puntos

            return distancia;
        }
    }
}
