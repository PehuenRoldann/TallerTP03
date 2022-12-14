using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_FigurasGeometricas
{
    internal class Triangulo : FiguraGeometrica
    {
        //CAMPOS
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        //CONSTRUCTORES
        /// <summary>
        /// Crea un nuevo objeto de la calse Triangulo
        /// </summary>
        /// <param name="iPunto1">Primer vertice</param>
        /// <param name="iPunto2">Segundo vertice</param>
        /// <param name="iPunto3">Tercer vertice</param>
        public Triangulo(Punto iPunto1, Punto iPunto2, Punto iPunto3)
        {
            this.iPunto1 = iPunto1;
            this.iPunto2 = iPunto2;
            this.iPunto3 = iPunto3;
        }

        //PROPIEDADES
        public Punto Punto1
        {
            get { return this.iPunto1; }
            set { this.iPunto1 = value; }
        }

        public Punto Punto2
        {
            get { return this.iPunto2; }
            set { this.iPunto2 = value; }
        }

        public Punto Punto3
        {
            get { return this.iPunto3; }
            set { this.iPunto3 = value; }
        }

        //MÉTODOS
        /// <summary>
        /// Método que calcula el área del triangulo.
        /// </summary>
        /// <returns>Área del triangulo.</returns>
        public override double CalcularArea()
        {
            return (iPunto1.X * iPunto2.Y + iPunto2.X * iPunto3.Y + iPunto3.X * iPunto1.Y - (iPunto1.Y * iPunto2.X + iPunto2.Y * iPunto3.X + iPunto3.Y * iPunto1.X)) / 2;
        }

        /// <summary>
        /// Método que calcula el perímetro del triángulo.
        /// </summary>
        /// <returns>Perímetro del triángulo</returns>
        public override double CalcularPerimetro()
        {
            return iPunto1.CalcularDistanciaDesde(iPunto2) + iPunto1.CalcularDistanciaDesde(iPunto3) + iPunto2.CalcularDistanciaDesde(iPunto3);
        }
    }
}
