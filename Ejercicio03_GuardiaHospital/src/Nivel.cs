using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_GuardiaHospital.src
{
    internal class Nivel
    {
        //CAMPOS
        private int _prioridad;
        private string _descripcion;

        //PROPIEDADES
        public int Prioridad { get { return _prioridad; } set { _prioridad = value; } }

        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }

    }
}
