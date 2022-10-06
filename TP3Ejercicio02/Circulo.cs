using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_Figuras
{
    internal class Circulo : FiguraGeometrica
    {
        //ATRIBUTOS
        private double iRadio;
        private Punto iCentro;

        //CONSTRUCTORES
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = pCentro;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = new Punto(pX, pY);
        }

        //PROPIEDADES
        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }

        //MÉTODOS
        public override double CalcularArea()
        {
            return Math.PI * this.Radio * this.Radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.Radio;
        }
    }
}
